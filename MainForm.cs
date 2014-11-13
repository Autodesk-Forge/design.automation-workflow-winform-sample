using System;
using System.Collections.Generic;
using System.Collections.Specialized;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace AutoCADIODemo
{
    public partial class MainForm : Form
    {
        private Dictionary<String, String> storedResults;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            storedResults = new Dictionary<string, string>();

            // Initial setup to get started
            Autodesk.AcadIOUtils.SetupAutoCADIOContainer(Properties.Settings.Default.AutoCADIOClientId, Properties.Settings.Default.AutoCADIOClientSecret);

            // Bucket name that we will use in Amazon S3 for uploading our drawings 
            Autodesk.GeneralUtils.S3BucketName = Properties.Settings.Default.S3BucketName;

            // Loads the drawing names in list
            LoadDrawingsList();

            // Loads the activity names in combobox
            LoadActivitiesList();
        }

        // Loads the drawing names in list
        private void LoadActivitiesList()
        {
            ActivityComboBox.Items.Clear();
            Dictionary<String, String> activityDetails = Autodesk.AcadIOUtils.GetActivityDetails();
            if (activityDetails.Count > 0)
            {
                foreach (KeyValuePair<String, String> kp in activityDetails)
                {
                    ActivityComboBox.Items.Add(kp.Key);
                }
                ActivityComboBox.SelectedIndex = 0;
            }
        }

        // Loads the activity names in combobox
        private void LoadDrawingsList()
        {
            DrawingsList.Items.Clear();

            if (Directory.Exists( Properties.Settings.Default.DrawingsFolderPath) == false)
            {
                System.Windows.Forms.MessageBox.Show("Drawings folder path not found ! Please set the path using Settings.");
            }
            else
            {
                DirectoryInfo di = new DirectoryInfo( Properties.Settings.Default.DrawingsFolderPath);
                FileInfo[] fi = di.GetFiles("*.dwg");

                foreach (FileInfo info in fi)
                {
                    //drawings.Add(info.FullName);
                    DrawingsList.Items.Add(Path.GetFileName(info.FullName));
                }
                //
                // we do not want the preview to start immediately on loading. 
                // this could delay startup, so let user click on a drawing from the list.
                //if (DrawingsList1.Items.Count > 0)
                //    DrawingsList1.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Generates preview image of the drawing file path passed to it as parameter using the PlotToPDF activity.
        /// its result is displayed in a web browser.
        /// </summary>
        /// <param name="drawingPath"></param>
        private void GetAutoCADIOResult(string drawingPath, String activityId, bool considerStoredResult)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                String storedResultUrl = String.Empty;
                
                if(storedResults.ContainsKey(drawingPath))
                    storedResultUrl = storedResults[drawingPath];

                if (considerStoredResult  && 
                    ! String.IsNullOrEmpty(storedResultUrl))
                {
                    UpdateStatusText(String.Format("URL : {0}", storedResultUrl));

                    // Display stored result
                    String localFilePath = String.Empty;
                    if (Autodesk.GeneralUtils.Download(storedResultUrl, ref localFilePath))
                    {
                        if (storedResultUrl.Contains(".pdf"))
                        {
                            webBrowser.Url = new Uri(storedResultUrl);
                            UpdateStatusText(String.Format("Result downloaded to {0}", localFilePath));
                        }
                        else
                        {
                            UpdateWebbrowserMsg(String.Format("Result downloaded to <strong>{0}</strong>", localFilePath));
                        }
                    }
                    else
                    {
                        UpdateWebbrowserMsg(String.Format("Sorry, could not downloaded from <strong>{0}</strong>", storedResultUrl));
                    }
                }
                else
                {
                    UpdateStatusText("Uploading drawing to S3");

                    // Step 1 : Upload the drawing to S3 storage
                    String hostDwgS3Url = Autodesk.GeneralUtils.UploadDrawingToS3(drawingPath);

                    if (String.IsNullOrEmpty(hostDwgS3Url))
                        return;

                    UpdateStatusText("Submitting workitem to AutoCADIO");

                    // Step 2 : Submit a AutoCADIO Workitem using the activity id
                    String resulturl = Autodesk.AcadIOUtils.SubmitWorkItem(activityId, hostDwgS3Url);

                    // Step 3 : Display the result in a web browser and download the result
                    if (String.IsNullOrEmpty(resulturl) == false)
                    {
                        UpdateStatusText(String.Format("URL : {0}", resulturl));

                        Download(resulturl);

                        // Store the result if needed
                        if (String.IsNullOrEmpty(storedResultUrl) == false)
                            storedResults.Remove(drawingPath);
                        storedResults.Add(drawingPath, resulturl);
                    }
                    else
                        UpdateStatusText("workitem result url is empty !");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        // Downloads the result from the url and displays the result in a browser control
        private void Download(String url)
        {
            try
            {
                // Load the url in web browser
                String localFilePath = String.Empty;
                if (Autodesk.GeneralUtils.Download(url, ref localFilePath))
                {
                    if (!String.IsNullOrEmpty(localFilePath))
                    {
                        if (url.Contains(".pdf"))
                        {
                            webBrowser.Url = new Uri(url);
                            UpdateStatusText(String.Format("Result downloaded to {0}", localFilePath));
                        }
                        else
                        {
                            UpdateWebbrowserMsg(String.Format("Result downloaded to <strong>{0}</strong>", localFilePath));
                        }
                    }
                    else
                    {
                        UpdateWebbrowserMsg(String.Format("Sorry, could not downloaded from <strong>{0}</strong>", url));
                    }
                }
            }
            catch (System.UriFormatException)
            {
                System.Windows.Forms.MessageBox.Show(url + "could not be loaded.");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdateStatusText(String msg)
        {
            StatusLabel.Text = msg;
        }

        private void UpdateWebbrowserMsg(String htmlmsg)
        {
            webBrowser.Navigate("about:blank");
            webBrowser.Document.Write(String.Format("<html><body>{0}</body></html>", htmlmsg));
            webBrowser.Refresh();
        }

        /// <summary>
        /// when a different drawing is selected in the listbox, update the preview result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawingsList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DrawingsList.SelectedIndex != -1)
            {
                // Get the currently selected drawing and get result for the selected activity from AutoCADIO
                GetAutoCADIOResult(Path.Combine(Properties.Settings.Default.DrawingsFolderPath, DrawingsList.SelectedItem.ToString()), ActivityComboBox.SelectedItem.ToString(), false);
            }
        }

        // Display settings form to set up the client id and client secret.
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            string autocadioclientid = Properties.Settings.Default.AutoCADIOClientId;
            string autocadioclientsecret = Properties.Settings.Default.AutoCADIOClientSecret;
            string drawingsFolderPath = Properties.Settings.Default.DrawingsFolderPath;

            SettingsForm sf = new SettingsForm();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (drawingsFolderPath != Properties.Settings.Default.DrawingsFolderPath)
                {
                    LoadDrawingsList();

                    storedResults.Clear();
                }
                drawingsFolderPath = Properties.Settings.Default.DrawingsFolderPath;

                if (autocadioclientid != Properties.Settings.Default.AutoCADIOClientId ||
                   autocadioclientsecret != Properties.Settings.Default.AutoCADIOClientSecret)
                {
                    Autodesk.AcadIOUtils.SetupAutoCADIOContainer(Properties.Settings.Default.AutoCADIOClientId, Properties.Settings.Default.AutoCADIOClientSecret);
                }
            }
        }

        // About this sample
        private void AboutButton_Click(object sender, EventArgs e)
        {
            String sContent = "AutoCADIO Demo 1.0\nDeveloper Technical Services\nAutodesk";
            System.Windows.Forms.MessageBox.Show(sContent, "About AutoCADIO Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Get the result again for the selected activity / drawing 
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (DrawingsList.SelectedIndex != -1)
            {
                // Get the currently selected drawing and get result for the selected activity from AutoCADIO
                GetAutoCADIOResult(Path.Combine(Properties.Settings.Default.DrawingsFolderPath, DrawingsList.SelectedItem.ToString()), ActivityComboBox.SelectedItem.ToString(), false);
            }
        }

        // Activity changed
        private void ActivityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            storedResults.Clear();
        }

        // Display the activity form to create / delete activities
        private void ActivityBtn_Click(object sender, EventArgs e)
        {
            ActivitiesForm af = new ActivitiesForm();
            af.ShowDialog();
            LoadActivitiesList();
        }

        // Display the appPackage form to create / delete appPackages
        private void PackageBtn_Click(object sender, EventArgs e)
        {
            AppPackageForm pf = new AppPackageForm();
            pf.ShowDialog();
        }
    }
}
