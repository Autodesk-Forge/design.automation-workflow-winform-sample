namespace AutoCADIODemo
{
    partial class ActivitiesForm
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
            this.ScriptText = new System.Windows.Forms.TextBox();
            this.ActivitiesList = new System.Windows.Forms.ListBox();
            this.ActivityIdText = new System.Windows.Forms.TextBox();
            this.LinkedPackagesList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LinkedPackageGroupBox = new System.Windows.Forms.GroupBox();
            this.ActivityIdGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteActivityBtn = new System.Windows.Forms.Button();
            this.NewActivityBtn = new System.Windows.Forms.Button();
            this.AddLinkedPackage = new System.Windows.Forms.Button();
            this.RemoveLinkedPackageBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AvailablePackagesList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.LinkedPackageGroupBox.SuspendLayout();
            this.ActivityIdGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScriptText
            // 
            this.ScriptText.CausesValidation = false;
            this.ScriptText.Location = new System.Drawing.Point(6, 21);
            this.ScriptText.Multiline = true;
            this.ScriptText.Name = "ScriptText";
            this.ScriptText.Size = new System.Drawing.Size(459, 71);
            this.ScriptText.TabIndex = 0;
            // 
            // ActivitiesList
            // 
            this.ActivitiesList.CausesValidation = false;
            this.ActivitiesList.FormattingEnabled = true;
            this.ActivitiesList.ItemHeight = 16;
            this.ActivitiesList.Location = new System.Drawing.Point(6, 21);
            this.ActivitiesList.Name = "ActivitiesList";
            this.ActivitiesList.Size = new System.Drawing.Size(459, 100);
            this.ActivitiesList.TabIndex = 1;
            this.ActivitiesList.SelectedIndexChanged += new System.EventHandler(this.ActivitiesList_SelectedIndexChanged);
            // 
            // ActivityIdText
            // 
            this.ActivityIdText.CausesValidation = false;
            this.ActivityIdText.Location = new System.Drawing.Point(6, 21);
            this.ActivityIdText.Name = "ActivityIdText";
            this.ActivityIdText.Size = new System.Drawing.Size(459, 22);
            this.ActivityIdText.TabIndex = 4;
            // 
            // LinkedPackagesList
            // 
            this.LinkedPackagesList.CausesValidation = false;
            this.LinkedPackagesList.FormattingEnabled = true;
            this.LinkedPackagesList.ItemHeight = 16;
            this.LinkedPackagesList.Location = new System.Drawing.Point(6, 21);
            this.LinkedPackagesList.Name = "LinkedPackagesList";
            this.LinkedPackagesList.Size = new System.Drawing.Size(189, 68);
            this.LinkedPackagesList.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScriptText);
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 98);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script";
            // 
            // LinkedPackageGroupBox
            // 
            this.LinkedPackageGroupBox.Controls.Add(this.LinkedPackagesList);
            this.LinkedPackageGroupBox.Location = new System.Drawing.Point(12, 206);
            this.LinkedPackageGroupBox.Name = "LinkedPackageGroupBox";
            this.LinkedPackageGroupBox.Size = new System.Drawing.Size(204, 94);
            this.LinkedPackageGroupBox.TabIndex = 14;
            this.LinkedPackageGroupBox.TabStop = false;
            this.LinkedPackageGroupBox.Text = "Linked Packages";
            // 
            // ActivityIdGroupBox
            // 
            this.ActivityIdGroupBox.Controls.Add(this.ActivityIdText);
            this.ActivityIdGroupBox.Location = new System.Drawing.Point(12, 149);
            this.ActivityIdGroupBox.Name = "ActivityIdGroupBox";
            this.ActivityIdGroupBox.Size = new System.Drawing.Size(471, 51);
            this.ActivityIdGroupBox.TabIndex = 15;
            this.ActivityIdGroupBox.TabStop = false;
            this.ActivityIdGroupBox.Text = "Activity Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ActivitiesList);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 130);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AutoCADIO Activities";
            // 
            // DeleteActivityBtn
            // 
            this.DeleteActivityBtn.CausesValidation = false;
            this.DeleteActivityBtn.Image = global::AutoCADIODemo.Properties.Resources.ActivityDelete;
            this.DeleteActivityBtn.Location = new System.Drawing.Point(231, 416);
            this.DeleteActivityBtn.Name = "DeleteActivityBtn";
            this.DeleteActivityBtn.Size = new System.Drawing.Size(105, 41);
            this.DeleteActivityBtn.TabIndex = 6;
            this.DeleteActivityBtn.UseVisualStyleBackColor = true;
            this.DeleteActivityBtn.Click += new System.EventHandler(this.DeleteActivityBtn_Click);
            // 
            // NewActivityBtn
            // 
            this.NewActivityBtn.CausesValidation = false;
            this.NewActivityBtn.Image = global::AutoCADIODemo.Properties.Resources.ActivityAdd;
            this.NewActivityBtn.Location = new System.Drawing.Point(109, 416);
            this.NewActivityBtn.Name = "NewActivityBtn";
            this.NewActivityBtn.Size = new System.Drawing.Size(105, 41);
            this.NewActivityBtn.TabIndex = 2;
            this.NewActivityBtn.UseVisualStyleBackColor = true;
            this.NewActivityBtn.Click += new System.EventHandler(this.NewActivityBtn_Click);
            // 
            // AddLinkedPackage
            // 
            this.AddLinkedPackage.Location = new System.Drawing.Point(231, 227);
            this.AddLinkedPackage.Name = "AddLinkedPackage";
            this.AddLinkedPackage.Size = new System.Drawing.Size(41, 30);
            this.AddLinkedPackage.TabIndex = 18;
            this.AddLinkedPackage.Text = "<<";
            this.AddLinkedPackage.UseVisualStyleBackColor = true;
            this.AddLinkedPackage.Click += new System.EventHandler(this.AddLinkedPackage_Click);
            // 
            // RemoveLinkedPackageBtn
            // 
            this.RemoveLinkedPackageBtn.Location = new System.Drawing.Point(230, 263);
            this.RemoveLinkedPackageBtn.Name = "RemoveLinkedPackageBtn";
            this.RemoveLinkedPackageBtn.Size = new System.Drawing.Size(42, 32);
            this.RemoveLinkedPackageBtn.TabIndex = 19;
            this.RemoveLinkedPackageBtn.Text = ">>";
            this.RemoveLinkedPackageBtn.UseVisualStyleBackColor = true;
            this.RemoveLinkedPackageBtn.Click += new System.EventHandler(this.RemoveLinkedPackageBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AvailablePackagesList);
            this.groupBox3.Location = new System.Drawing.Point(283, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 94);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Packages";
            // 
            // AvailablePackagesList
            // 
            this.AvailablePackagesList.CausesValidation = false;
            this.AvailablePackagesList.FormattingEnabled = true;
            this.AvailablePackagesList.ItemHeight = 16;
            this.AvailablePackagesList.Location = new System.Drawing.Point(6, 21);
            this.AvailablePackagesList.Name = "AvailablePackagesList";
            this.AvailablePackagesList.Size = new System.Drawing.Size(189, 68);
            this.AvailablePackagesList.TabIndex = 7;
            // 
            // ActivitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RemoveLinkedPackageBtn);
            this.Controls.Add(this.AddLinkedPackage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ActivityIdGroupBox);
            this.Controls.Add(this.LinkedPackageGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteActivityBtn);
            this.Controls.Add(this.NewActivityBtn);
            this.Name = "ActivitiesForm";
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.ActivitiesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LinkedPackageGroupBox.ResumeLayout(false);
            this.ActivityIdGroupBox.ResumeLayout(false);
            this.ActivityIdGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ScriptText;
        private System.Windows.Forms.ListBox ActivitiesList;
        private System.Windows.Forms.Button NewActivityBtn;
        private System.Windows.Forms.TextBox ActivityIdText;
        private System.Windows.Forms.Button DeleteActivityBtn;
        private System.Windows.Forms.ListBox LinkedPackagesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox LinkedPackageGroupBox;
        private System.Windows.Forms.GroupBox ActivityIdGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddLinkedPackage;
        private System.Windows.Forms.Button RemoveLinkedPackageBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox AvailablePackagesList;
    }
}