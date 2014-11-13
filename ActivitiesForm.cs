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

namespace AutoCADIODemo
{
    public partial class ActivitiesForm : Form
    {
        Dictionary<String, String> activityDetails = new Dictionary<string, string>();
        Dictionary<String, String> packageDetails = new Dictionary<string, string>();

        String _activityId = String.Empty;
        String _script = String.Empty;

        public ActivitiesForm()
        {
            InitializeComponent();
        }

        private void LoadActivitiesList()
        {
            activityDetails = Autodesk.AcadIOUtils.GetActivityDetails();
            ActivitiesList.Items.Clear();
            foreach (KeyValuePair<String, String> kp in activityDetails)
            {
                ActivitiesList.Items.Add(kp.Key);
            }

            if (ActivitiesList.Items.Count > 0)
                ActivitiesList.SelectedIndex = 0;
        }

        private void LoadPackagesList()
        {
            packageDetails = Autodesk.AcadIOUtils.GetAppPackageDetails();
            AvailablePackagesList.Items.Clear();
            foreach (KeyValuePair<String, String> kp in packageDetails)
            {
                AvailablePackagesList.Items.Add(kp.Key);
            }

            if (AvailablePackagesList.Items.Count > 0)
                AvailablePackagesList.SelectedIndex = 0;
        }

        private void ActivitiesForm_Load(object sender, EventArgs e)
        {
            LoadActivitiesList();
            LoadPackagesList();
        }

        private void ActivitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ActivitiesList.SelectedIndex;

            if (index > -1 && index < activityDetails.Count)
            {
                _activityId = ActivitiesList.SelectedItem.ToString();
                String value = activityDetails[_activityId];

                _script = value;

                ActivityIdText.Text = _activityId;
                ScriptText.Text = _script;
            }
        }

        private void NewActivityBtn_Click(object sender, EventArgs e)
        {
            // User Id is our AutoCADIO Client Id
            String userId = Properties.Settings.Default.AutoCADIOClientId;
            
            // Activity Id and script as provided in the text boxes
            String activityId = ActivityIdText.Text;
            String script = ScriptText.Text;

            if (!String.IsNullOrEmpty(userId) && !String.IsNullOrEmpty(activityId) && !String.IsNullOrEmpty(script))
            {
                // Create the activity
                if (Autodesk.AcadIOUtils.CreateActivity(activityId, script))
                {
                    // Link activity with any package that may be selected for linking with this activity
                    foreach (String linkedPackage in LinkedPackagesList.Items)
                    {
                        String packageId = linkedPackage;
                        if (Autodesk.AcadIOUtils.LinkAppPackage2Activity(activityId, packageId) == false)
                            break;
                    }
                    
                    LoadActivitiesList();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Sorry, could not create new activity.");
            }
        }

        private void DeleteActivityBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_activityId))
            {
                Cursor.Current = Cursors.WaitCursor;

                if (Autodesk.AcadIOUtils.DeleteActivity(_activityId))
                    LoadActivitiesList();

                Cursor.Current = Cursors.Default;
            }
        }

        private void AddLinkedPackage_Click(object sender, EventArgs e)
        {
            int index = AvailablePackagesList.SelectedIndex;
            if (index > -1)
            {
                foreach (var linkedPackage in LinkedPackagesList.Items)
                {
                    if (linkedPackage.ToString().Equals(AvailablePackagesList.SelectedItem.ToString()))
                    { // Already added.
                        return;
                    }
                }
                LinkedPackagesList.Items.Add(AvailablePackagesList.SelectedItem.ToString());
            }
        }

        private void RemoveLinkedPackageBtn_Click(object sender, EventArgs e)
        {
            int index = LinkedPackagesList.SelectedIndex;
            if (index > -1)
            {
                LinkedPackagesList.Items.RemoveAt(index);
            }
        }
    }
}