using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoCADIODemo
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            // Populate the settings form based on the values saved in the default settings.
            drawingsFolderPathTextBox.Text = Properties.Settings.Default.DrawingsFolderPath;
            AutoCADIOClientIDText.Text = Properties.Settings.Default.DesignAutoClientId;
            AutoCADIOClientSecretText.Text = Properties.Settings.Default.DesignAutoClientSecret;
        }

        /// <summary>
        /// On click of the save button, persist the changes made to the settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Update the default settings based on the values specified by the user and save it.
            Properties.Settings.Default.DesignAutoClientId = AutoCADIOClientIDText.Text;
            Properties.Settings.Default.DesignAutoClientSecret = AutoCADIOClientSecretText.Text;
            Properties.Settings.Default.DrawingsFolderPath = drawingsFolderPathTextBox.Text;

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Displays the browse folder dialog to select the drawings folder path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseFolderBtn_Click(object sender, EventArgs e)
        {
            if (DrawingsFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                drawingsFolderPathTextBox.Text = DrawingsFolderBrowser.SelectedPath;
            }
        }
    }
}
