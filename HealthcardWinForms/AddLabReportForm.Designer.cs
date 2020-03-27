namespace HealthcardWinForms
{
    partial class AddLabReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLabReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fillInRequiredLabel = new System.Windows.Forms.Label();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.ToPatientLabel = new System.Windows.Forms.Label();
            this.ForPatientTextBox = new System.Windows.Forms.TextBox();
            this.ReportNameLabel = new System.Windows.Forms.Label();
            this.ReportNameTextBox = new System.Windows.Forms.TextBox();
            this.ReportLabel = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ReportDescriptionLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.ReportDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HintLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.fillInRequiredLabel);
            this.panel1.Controls.Add(this.navigationLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 747);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // fillInRequiredLabel
            // 
            this.fillInRequiredLabel.AutoSize = true;
            this.fillInRequiredLabel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillInRequiredLabel.Location = new System.Drawing.Point(83, 249);
            this.fillInRequiredLabel.Name = "fillInRequiredLabel";
            this.fillInRequiredLabel.Size = new System.Drawing.Size(0, 23);
            this.fillInRequiredLabel.TabIndex = 1;
            // 
            // navigationLabel
            // 
            this.navigationLabel.AutoSize = true;
            this.navigationLabel.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationLabel.Location = new System.Drawing.Point(52, 200);
            this.navigationLabel.Name = "navigationLabel";
            this.navigationLabel.Size = new System.Drawing.Size(180, 33);
            this.navigationLabel.TabIndex = 0;
            this.navigationLabel.Text = "Report Form";
            // 
            // ToPatientLabel
            // 
            this.ToPatientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToPatientLabel.AutoSize = true;
            this.ToPatientLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ToPatientLabel.Location = new System.Drawing.Point(501, 63);
            this.ToPatientLabel.Name = "ToPatientLabel";
            this.ToPatientLabel.Size = new System.Drawing.Size(128, 23);
            this.ToPatientLabel.TabIndex = 13;
            this.ToPatientLabel.Text = "For Patient *";
            // 
            // ForPatientTextBox
            // 
            this.ForPatientTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ForPatientTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ForPatientTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ForPatientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForPatientTextBox.Location = new System.Drawing.Point(651, 63);
            this.ForPatientTextBox.Name = "ForPatientTextBox";
            this.ForPatientTextBox.Size = new System.Drawing.Size(274, 22);
            this.ForPatientTextBox.TabIndex = 14;
            // 
            // ReportNameLabel
            // 
            this.ReportNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportNameLabel.AutoSize = true;
            this.ReportNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ReportNameLabel.Location = new System.Drawing.Point(472, 122);
            this.ReportNameLabel.Name = "ReportNameLabel";
            this.ReportNameLabel.Size = new System.Drawing.Size(157, 23);
            this.ReportNameLabel.TabIndex = 15;
            this.ReportNameLabel.Text = "Report Name *";
            // 
            // ReportNameTextBox
            // 
            this.ReportNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ReportNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ReportNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportNameTextBox.Location = new System.Drawing.Point(651, 123);
            this.ReportNameTextBox.Name = "ReportNameTextBox";
            this.ReportNameTextBox.Size = new System.Drawing.Size(274, 22);
            this.ReportNameTextBox.TabIndex = 16;
            // 
            // ReportLabel
            // 
            this.ReportLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ReportLabel.Location = new System.Drawing.Point(539, 189);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(90, 23);
            this.ReportLabel.TabIndex = 17;
            this.ReportLabel.Text = "Report *";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrowseButton.Location = new System.Drawing.Point(651, 180);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(120, 32);
            this.BrowseButton.TabIndex = 18;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ReportDescriptionLabel
            // 
            this.ReportDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportDescriptionLabel.AutoSize = true;
            this.ReportDescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ReportDescriptionLabel.Location = new System.Drawing.Point(426, 248);
            this.ReportDescriptionLabel.Name = "ReportDescriptionLabel";
            this.ReportDescriptionLabel.Size = new System.Drawing.Size(203, 23);
            this.ReportDescriptionLabel.TabIndex = 19;
            this.ReportDescriptionLabel.Text = "Report Description *";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.FileNameLabel.Location = new System.Drawing.Point(811, 189);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 23);
            this.FileNameLabel.TabIndex = 20;
            // 
            // ReportDescriptionRichTextBox
            // 
            this.ReportDescriptionRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportDescriptionRichTextBox.Location = new System.Drawing.Point(651, 248);
            this.ReportDescriptionRichTextBox.Name = "ReportDescriptionRichTextBox";
            this.ReportDescriptionRichTextBox.Size = new System.Drawing.Size(342, 122);
            this.ReportDescriptionRichTextBox.TabIndex = 21;
            this.ReportDescriptionRichTextBox.Text = "";
            // 
            // SaveReportButton
            // 
            this.SaveReportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveReportButton.Location = new System.Drawing.Point(651, 451);
            this.SaveReportButton.Name = "SaveReportButton";
            this.SaveReportButton.Size = new System.Drawing.Size(120, 34);
            this.SaveReportButton.TabIndex = 22;
            this.SaveReportButton.Text = "Save";
            this.SaveReportButton.UseVisualStyleBackColor = true;
            this.SaveReportButton.Click += new System.EventHandler(this.SaveReportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 23;
            // 
            // HintLabel
            // 
            this.HintLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HintLabel.AutoSize = true;
            this.HintLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintLabel.Location = new System.Drawing.Point(472, 598);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(780, 23);
            this.HintLabel.TabIndex = 24;
            this.HintLabel.Text = "Note: To add another medicine click on save, then you can add more to prescriptio" +
    "n";
            // 
            // AddLabReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 747);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveReportButton);
            this.Controls.Add(this.ReportDescriptionRichTextBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.ReportDescriptionLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.ReportNameTextBox);
            this.Controls.Add(this.ReportNameLabel);
            this.Controls.Add(this.ForPatientTextBox);
            this.Controls.Add(this.ToPatientLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AddLabReportForm";
            this.Text = "AddLabReportForm";
            this.Load += new System.EventHandler(this.AddLabReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fillInRequiredLabel;
        private System.Windows.Forms.Label navigationLabel;
        private System.Windows.Forms.Label ToPatientLabel;
        private System.Windows.Forms.TextBox ForPatientTextBox;
        private System.Windows.Forms.Label ReportNameLabel;
        private System.Windows.Forms.TextBox ReportNameTextBox;
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label ReportDescriptionLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.RichTextBox ReportDescriptionRichTextBox;
        private System.Windows.Forms.Button SaveReportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HintLabel;
    }
}