namespace HealthcardWinForms
{
    partial class ViewPrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPrescriptionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewPrescriptionLabel = new System.Windows.Forms.Label();
            this.PrescriptionListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MedicineID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ViewPrescriptionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 747);
            this.panel1.TabIndex = 3;
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
            // ViewPrescriptionLabel
            // 
            this.ViewPrescriptionLabel.AutoSize = true;
            this.ViewPrescriptionLabel.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPrescriptionLabel.Location = new System.Drawing.Point(52, 200);
            this.ViewPrescriptionLabel.Name = "ViewPrescriptionLabel";
            this.ViewPrescriptionLabel.Size = new System.Drawing.Size(259, 33);
            this.ViewPrescriptionLabel.TabIndex = 0;
            this.ViewPrescriptionLabel.Text = "View Prescriptions";
            // 
            // PrescriptionListView
            // 
            this.PrescriptionListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrescriptionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PatientID,
            this.PatientName,
            this.MedicineID,
            this.Date});
            this.PrescriptionListView.FullRowSelect = true;
            this.PrescriptionListView.HideSelection = false;
            this.PrescriptionListView.Location = new System.Drawing.Point(451, 121);
            this.PrescriptionListView.Name = "PrescriptionListView";
            this.PrescriptionListView.Size = new System.Drawing.Size(958, 586);
            this.PrescriptionListView.TabIndex = 4;
            this.PrescriptionListView.UseCompatibleStateImageBehavior = false;
            this.PrescriptionListView.View = System.Windows.Forms.View.Details;
            this.PrescriptionListView.SelectedIndexChanged += new System.EventHandler(this.PrescriptionListView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 75;
            // 
            // PatientID
            // 
            this.PatientID.Text = "PatientID";
            this.PatientID.Width = 144;
            // 
            // PatientName
            // 
            this.PatientName.Text = "PatientName";
            this.PatientName.Width = 219;
            // 
            // MedicineID
            // 
            this.MedicineID.Text = "MedicineID";
            this.MedicineID.Width = 260;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 194;
            // 
            // ViewPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 747);
            this.Controls.Add(this.PrescriptionListView);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPrescriptionForm";
            this.Text = "ViewPrescriptionForm";
            this.Load += new System.EventHandler(this.ViewPrescriptionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ViewPrescriptionLabel;
        private System.Windows.Forms.ListView PrescriptionListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader PatientID;
        private System.Windows.Forms.ColumnHeader PatientName;
        private System.Windows.Forms.ColumnHeader MedicineID;
        private System.Windows.Forms.ColumnHeader Date;
    }
}