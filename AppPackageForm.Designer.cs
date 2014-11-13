namespace AutoCADIODemo
{
    partial class AppPackageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AppPackagesList = new System.Windows.Forms.ListBox();
            this.PackageIdText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResourceText = new System.Windows.Forms.TextBox();
            this.DownloadPackageBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PackageIdGroupBox = new System.Windows.Forms.GroupBox();
            this.DeletePackageBtn = new System.Windows.Forms.Button();
            this.NewPackageBtn = new System.Windows.Forms.Button();
            this.bundleFolderBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListedCommandsText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PackageIdGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppPackagesList
            // 
            this.AppPackagesList.CausesValidation = false;
            this.AppPackagesList.FormattingEnabled = true;
            this.AppPackagesList.ItemHeight = 16;
            this.AppPackagesList.Location = new System.Drawing.Point(6, 21);
            this.AppPackagesList.Name = "AppPackagesList";
            this.AppPackagesList.Size = new System.Drawing.Size(386, 100);
            this.AppPackagesList.TabIndex = 1;
            this.AppPackagesList.SelectedIndexChanged += new System.EventHandler(this.AppPackagesList_SelectedIndexChanged);
            // 
            // PackageIdText
            // 
            this.PackageIdText.CausesValidation = false;
            this.PackageIdText.Location = new System.Drawing.Point(6, 21);
            this.PackageIdText.Name = "PackageIdText";
            this.PackageIdText.Size = new System.Drawing.Size(386, 22);
            this.PackageIdText.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResourceText);
            this.groupBox1.Controls.Add(this.DownloadPackageBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 58);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resource";
            // 
            // ResourceText
            // 
            this.ResourceText.CausesValidation = false;
            this.ResourceText.ForeColor = System.Drawing.Color.Blue;
            this.ResourceText.Location = new System.Drawing.Point(6, 21);
            this.ResourceText.Name = "ResourceText";
            this.ResourceText.ReadOnly = true;
            this.ResourceText.Size = new System.Drawing.Size(341, 22);
            this.ResourceText.TabIndex = 5;
            // 
            // DownloadPackageBtn
            // 
            this.DownloadPackageBtn.CausesValidation = false;
            this.DownloadPackageBtn.Image = global::AutoCADIODemo.Properties.Resources.Download;
            this.DownloadPackageBtn.Location = new System.Drawing.Point(353, 13);
            this.DownloadPackageBtn.Name = "DownloadPackageBtn";
            this.DownloadPackageBtn.Size = new System.Drawing.Size(43, 38);
            this.DownloadPackageBtn.TabIndex = 9;
            this.DownloadPackageBtn.UseVisualStyleBackColor = true;
            this.DownloadPackageBtn.Click += new System.EventHandler(this.DownloadPackageBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AppPackagesList);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 130);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AutoCADIO App Packages";
            // 
            // PackageIdGroupBox
            // 
            this.PackageIdGroupBox.Controls.Add(this.PackageIdText);
            this.PackageIdGroupBox.Location = new System.Drawing.Point(12, 154);
            this.PackageIdGroupBox.Name = "PackageIdGroupBox";
            this.PackageIdGroupBox.Size = new System.Drawing.Size(402, 51);
            this.PackageIdGroupBox.TabIndex = 22;
            this.PackageIdGroupBox.TabStop = false;
            this.PackageIdGroupBox.Text = "Package Id";
            // 
            // DeletePackageBtn
            // 
            this.DeletePackageBtn.CausesValidation = false;
            this.DeletePackageBtn.Image = global::AutoCADIODemo.Properties.Resources.PackageDelete;
            this.DeletePackageBtn.Location = new System.Drawing.Point(216, 395);
            this.DeletePackageBtn.Name = "DeletePackageBtn";
            this.DeletePackageBtn.Size = new System.Drawing.Size(105, 41);
            this.DeletePackageBtn.TabIndex = 19;
            this.DeletePackageBtn.UseVisualStyleBackColor = true;
            this.DeletePackageBtn.Click += new System.EventHandler(this.DeletePackageBtn_Click);
            // 
            // NewPackageBtn
            // 
            this.NewPackageBtn.CausesValidation = false;
            this.NewPackageBtn.Image = global::AutoCADIODemo.Properties.Resources.PackageAdd;
            this.NewPackageBtn.Location = new System.Drawing.Point(94, 395);
            this.NewPackageBtn.Name = "NewPackageBtn";
            this.NewPackageBtn.Size = new System.Drawing.Size(105, 41);
            this.NewPackageBtn.TabIndex = 18;
            this.NewPackageBtn.UseVisualStyleBackColor = true;
            this.NewPackageBtn.Click += new System.EventHandler(this.NewPackageBtn_Click);
            // 
            // bundleFolderBrowseDialog
            // 
            this.bundleFolderBrowseDialog.Description = "Please select the bundle folder to upload";
            this.bundleFolderBrowseDialog.ShowNewFolderButton = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListedCommandsText);
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 109);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listed commands";
            // 
            // ListedCommandsText
            // 
            this.ListedCommandsText.AcceptsReturn = true;
            this.ListedCommandsText.CausesValidation = false;
            this.ListedCommandsText.ForeColor = System.Drawing.Color.Blue;
            this.ListedCommandsText.Location = new System.Drawing.Point(6, 21);
            this.ListedCommandsText.Multiline = true;
            this.ListedCommandsText.Name = "ListedCommandsText";
            this.ListedCommandsText.ReadOnly = true;
            this.ListedCommandsText.Size = new System.Drawing.Size(386, 82);
            this.ListedCommandsText.TabIndex = 5;
            // 
            // AppPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 451);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PackageIdGroupBox);
            this.Controls.Add(this.DeletePackageBtn);
            this.Controls.Add(this.NewPackageBtn);
            this.Name = "AppPackageForm";
            this.Text = "App Packages";
            this.Load += new System.EventHandler(this.AppPackageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.PackageIdGroupBox.ResumeLayout(false);
            this.PackageIdGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AppPackagesList;
        private System.Windows.Forms.TextBox PackageIdText;
        private System.Windows.Forms.Button DownloadPackageBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox PackageIdGroupBox;
        private System.Windows.Forms.Button DeletePackageBtn;
        private System.Windows.Forms.Button NewPackageBtn;
        private System.Windows.Forms.TextBox ResourceText;
        private System.Windows.Forms.FolderBrowserDialog bundleFolderBrowseDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ListedCommandsText;
    }
}