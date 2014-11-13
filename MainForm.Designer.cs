namespace AutoCADIODemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.DrawingsList = new System.Windows.Forms.ListBox();
            this.StatusLabel = new System.Windows.Forms.TextBox();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ActivityComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ActivityBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.PackageBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.TestButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(274, 28);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(986, 706);
            this.webBrowser.TabIndex = 0;
            // 
            // DrawingsList
            // 
            this.DrawingsList.BackColor = System.Drawing.Color.Aqua;
            this.DrawingsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrawingsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.DrawingsList.FormattingEnabled = true;
            this.DrawingsList.ItemHeight = 16;
            this.DrawingsList.Location = new System.Drawing.Point(12, 28);
            this.DrawingsList.Name = "DrawingsList";
            this.DrawingsList.Size = new System.Drawing.Size(256, 688);
            this.DrawingsList.TabIndex = 1;
            this.DrawingsList.SelectedIndexChanged += new System.EventHandler(this.DrawingsList_SelectedValueChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Cyan;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusLabel.Location = new System.Drawing.Point(13, 740);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.ReadOnly = true;
            this.StatusLabel.Size = new System.Drawing.Size(1247, 15);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.TabStop = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsButton.Image = global::AutoCADIODemo.AutoCADIODemo.SettingsImage;
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(23, 25);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.ToolTipText = "Configure settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutButton.Image = global::AutoCADIODemo.AutoCADIODemo.AboutImage;
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(23, 25);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::AutoCADIODemo.AutoCADIODemo.RefreshImage;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 25);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.BackColor = System.Drawing.Color.Aqua;
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(250, 28);
            // 
            // ActivityBtn
            // 
            this.ActivityBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ActivityBtn.Image = global::AutoCADIODemo.Properties.Resources.Activity;
            this.ActivityBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActivityBtn.Name = "ActivityBtn";
            this.ActivityBtn.Size = new System.Drawing.Size(23, 25);
            this.ActivityBtn.Click += new System.EventHandler(this.ActivityBtn_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsButton,
            this.PackageBtn,
            this.ActivityBtn,
            this.ActivityComboBox,
            this.RefreshButton,
            this.AboutButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1272, 28);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // PackageBtn
            // 
            this.PackageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PackageBtn.Image = global::AutoCADIODemo.Properties.Resources.Package;
            this.PackageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PackageBtn.Name = "PackageBtn";
            this.PackageBtn.Size = new System.Drawing.Size(23, 25);
            this.PackageBtn.ToolTipText = "App Packages";
            this.PackageBtn.Click += new System.EventHandler(this.PackageBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // TestButton
            // 
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(23, 23);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1272, 766);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DrawingsList);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AutoCADIO Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ListBox DrawingsList;
        private System.Windows.Forms.TextBox StatusLabel;
        private System.Windows.Forms.ToolStripButton SettingsButton;
        private System.Windows.Forms.ToolStripButton AboutButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripComboBox ActivityComboBox;
        private System.Windows.Forms.ToolStripButton ActivityBtn;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton TestButton;
        private System.Windows.Forms.ToolStripButton PackageBtn;
    }
}

