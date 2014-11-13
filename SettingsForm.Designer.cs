namespace AutoCADIODemo
{
    partial class SettingsForm
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
            this.drawingsFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseFolderBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DrawingsFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.AutoCADIOClientIDText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AutoCADIOClientSecretText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drawingsFolderPathTextBox
            // 
            this.drawingsFolderPathTextBox.Location = new System.Drawing.Point(179, 13);
            this.drawingsFolderPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.drawingsFolderPathTextBox.Name = "drawingsFolderPathTextBox";
            this.drawingsFolderPathTextBox.Size = new System.Drawing.Size(557, 22);
            this.drawingsFolderPathTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drawings folder path";
            // 
            // BrowseFolderBtn
            // 
            this.BrowseFolderBtn.Location = new System.Drawing.Point(747, 13);
            this.BrowseFolderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseFolderBtn.Name = "BrowseFolderBtn";
            this.BrowseFolderBtn.Size = new System.Drawing.Size(35, 28);
            this.BrowseFolderBtn.TabIndex = 5;
            this.BrowseFolderBtn.Text = "...";
            this.BrowseFolderBtn.UseVisualStyleBackColor = true;
            this.BrowseFolderBtn.Click += new System.EventHandler(this.BrowseFolderBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Location = new System.Drawing.Point(660, 60);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 65);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "AutoCADIO Client ID";
            // 
            // AutoCADIOClientIDText
            // 
            this.AutoCADIOClientIDText.Location = new System.Drawing.Point(179, 60);
            this.AutoCADIOClientIDText.Name = "AutoCADIOClientIDText";
            this.AutoCADIOClientIDText.Size = new System.Drawing.Size(455, 22);
            this.AutoCADIOClientIDText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "AutoCADIO Client Secret";
            // 
            // AutoCADIOClientSecretText
            // 
            this.AutoCADIOClientSecretText.Location = new System.Drawing.Point(179, 103);
            this.AutoCADIOClientSecretText.Name = "AutoCADIOClientSecretText";
            this.AutoCADIOClientSecretText.Size = new System.Drawing.Size(455, 22);
            this.AutoCADIOClientSecretText.TabIndex = 10;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 149);
            this.Controls.Add(this.AutoCADIOClientSecretText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AutoCADIOClientIDText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.BrowseFolderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawingsFolderPathTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox drawingsFolderPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseFolderBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.FolderBrowserDialog DrawingsFolderBrowser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AutoCADIOClientIDText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AutoCADIOClientSecretText;
    }
}