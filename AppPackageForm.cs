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

namespace AutoCADIODemo
{
    public partial class AppPackageForm : Form
    {
        Dictionary<String, String> _packageDetails = new Dictionary<string, string>();
        Dictionary<String, String> listedCommands = new Dictionary<string, string>();

        String _packageId = String.Empty;
        String _resource = String.Empty;

        public AppPackageForm()
        {
            InitializeComponent();
        }

        private void AppPackageForm_Load(object sender, EventArgs e)
        {
            LoadPackagesList();
        }

        private void LoadPackagesList()
        {
            _packageDetails = Autodesk.AcadIOUtils.GetAppPackageDetails();
            AppPackagesList.Items.Clear();
            foreach (KeyValuePair<String, String> kp in _packageDetails)
            {
                AppPackagesList.Items.Add(kp.Key);
            }

            if (AppPackagesList.Items.Count > 0)
                AppPackagesList.SelectedIndex = 0;
            else
            {
                PackageIdText.Text = "";
                ResourceText.Text = "";
                ListedCommandsText.Text = "";
            }
        }

        private void AppPackagesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = AppPackagesList.SelectedIndex;

            if (index > -1 && index < _packageDetails.Count)
            {
                String key = AppPackagesList.SelectedItem.ToString();
                _packageId = key;

                String value = _packageDetails[key];
                _resource = value;

                PackageIdText.Text = _packageId;
                ResourceText.Text = _resource;

                if (listedCommands.ContainsKey(key))
                {
                    ListedCommandsText.Text = listedCommands[key];
                }
                else
                {
                    String appPackageResource = _resource;
                    if (String.IsNullOrEmpty(appPackageResource) == false)
                    {
                        String localFilePath = String.Empty;
                        if (Autodesk.GeneralUtils.Download(appPackageResource, ref localFilePath))
                        {
                            StringCollection localCommands = new StringCollection();
                            StringCollection globalCommands = new StringCollection();

                            // Identify the commands listed in the downloaded bundle
                            Autodesk.GeneralUtils.FindListedCommands(localFilePath, ref localCommands, ref globalCommands);

                            StringBuilder commandsList = new StringBuilder();
                            foreach (String localCmd in localCommands)
                            {
                                commandsList.Append(localCmd);
                                commandsList.Append(Environment.NewLine);
                            }

                            listedCommands.Add(key, commandsList.ToString());

                            ListedCommandsText.Text = listedCommands[key];
                        }
                    }
                }
            }
        }

        private void DownloadPackageBtn_Click(object sender, EventArgs e)
        {
            String appPackageResource = ResourceText.Text;
            if (String.IsNullOrEmpty(appPackageResource) == false)
            {
                String localFilePath = String.Empty;
                if (Autodesk.GeneralUtils.Download(appPackageResource, ref localFilePath))
                {
                    System.Windows.Forms.MessageBox.Show(String.Format("AppPackage downloaded to {0}", localFilePath));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(String.Format("Sorry, could not downloaded AppPackage from {0}", appPackageResource));
                }
            }
        }

        private void NewPackageBtn_Click(object sender, EventArgs e)
        {
            String packageId = PackageIdText.Text;
            if (String.IsNullOrEmpty(packageId))
            {
                System.Windows.Forms.MessageBox.Show(String.Format("Please provide an id for the package"));
                return;
            }

            if (bundleFolderBrowseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                String packageZipFilePath = String.Empty;

                String bundleFolderPath = bundleFolderBrowseDialog.SelectedPath;

                if (Autodesk.AcadIOUtils.CreateAppPackageFromBundle(packageId, bundleFolderPath))
                {// App Package created ok
                    LoadPackagesList();
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    System.Windows.Forms.MessageBox.Show("Sorry, could not create new app package.");
                }
                
                Cursor.Current = Cursors.Default;
            }
        }

        private void DeletePackageBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_packageId))
            {
                Cursor.Current = Cursors.WaitCursor;

                if (Autodesk.AcadIOUtils.DeletePackage(_packageId))
                    LoadPackagesList();
                else
                {
                    Cursor.Current = Cursors.Default;
                    System.Windows.Forms.MessageBox.Show("Sorry, could not delete app package.");
                }

                Cursor.Current = Cursors.Default;
            }
        }
    }
}
