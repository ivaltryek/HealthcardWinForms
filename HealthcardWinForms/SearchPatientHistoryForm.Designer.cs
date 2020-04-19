namespace HealthcardWinForms
{
    partial class SearchPatientHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPatientHistoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fillInRequiredLabel = new System.Windows.Forms.Label();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.ToPatientLabel = new System.Windows.Forms.Label();
            this.ForPatientTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionSearchButton = new System.Windows.Forms.Button();
            this.reportsSearchButton = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 5;
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
            this.navigationLabel.Size = new System.Drawing.Size(282, 33);
            this.navigationLabel.TabIndex = 0;
            this.navigationLabel.Text = "Patient Data Search";
            // 
            // ToPatientLabel
            // 
            this.ToPatientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToPatientLabel.AutoSize = true;
            this.ToPatientLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ToPatientLabel.Location = new System.Drawing.Point(456, 105);
            this.ToPatientLabel.Name = "ToPatientLabel";
            this.ToPatientLabel.Size = new System.Drawing.Size(87, 23);
            this.ToPatientLabel.TabIndex = 14;
            this.ToPatientLabel.Text = "Patient*";
            // 
            // ForPatientTextBox
            // 
            this.ForPatientTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ForPatientTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ForPatientTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ForPatientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForPatientTextBox.Location = new System.Drawing.Point(599, 106);
            this.ForPatientTextBox.Name = "ForPatientTextBox";
            this.ForPatientTextBox.Size = new System.Drawing.Size(345, 22);
            this.ForPatientTextBox.TabIndex = 15;
            // 
            // prescriptionSearchButton
            // 
            this.prescriptionSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prescriptionSearchButton.Location = new System.Drawing.Point(599, 177);
            this.prescriptionSearchButton.Name = "prescriptionSearchButton";
            this.prescriptionSearchButton.Size = new System.Drawing.Size(155, 39);
            this.prescriptionSearchButton.TabIndex = 16;
            this.prescriptionSearchButton.Text = "View Prescriptions";
            this.prescriptionSearchButton.UseVisualStyleBackColor = true;
            this.prescriptionSearchButton.Click += new System.EventHandler(this.prescriptionSearchButton_Click);
            // 
            // reportsSearchButton
            // 
            this.reportsSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportsSearchButton.Location = new System.Drawing.Point(789, 177);
            this.reportsSearchButton.Name = "reportsSearchButton";
            this.reportsSearchButton.Size = new System.Drawing.Size(155, 39);
            this.reportsSearchButton.TabIndex = 17;
            this.reportsSearchButton.Text = "View Reports";
            this.reportsSearchButton.UseVisualStyleBackColor = true;
            this.reportsSearchButton.Click += new System.EventHandler(this.reportsSearchButton_Click);
            // 
            // SearchPatientHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 747);
            this.Controls.Add(this.reportsSearchButton);
            this.Controls.Add(this.prescriptionSearchButton);
            this.Controls.Add(this.ForPatientTextBox);
            this.Controls.Add(this.ToPatientLabel);
            this.Controls.Add(this.panel1);
            this.Name = "SearchPatientHistoryForm";
            this.Text = "SearchPatientHistoryForm";
            this.Load += new System.EventHandler(this.SearchPatientHistoryForm_Load);
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
        private System.Windows.Forms.Button prescriptionSearchButton;
        private System.Windows.Forms.Button reportsSearchButton;
    }
}