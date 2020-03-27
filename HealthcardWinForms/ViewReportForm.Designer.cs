namespace HealthcardWinForms
{
    partial class ViewReportForm
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
            this.ReportListView = new System.Windows.Forms.ListView();
            this.ReportID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LaboratorianName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReportName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UploadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ReportListView
            // 
            this.ReportListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReportID,
            this.PatientID,
            this.PatientName,
            this.LaboratorianName,
            this.ReportName,
            this.UploadDate,
            this.Description});
            this.ReportListView.FullRowSelect = true;
            this.ReportListView.HideSelection = false;
            this.ReportListView.Location = new System.Drawing.Point(42, 28);
            this.ReportListView.Name = "ReportListView";
            this.ReportListView.Size = new System.Drawing.Size(1410, 613);
            this.ReportListView.TabIndex = 0;
            this.ReportListView.UseCompatibleStateImageBehavior = false;
            this.ReportListView.View = System.Windows.Forms.View.Details;
            this.ReportListView.SelectedIndexChanged += new System.EventHandler(this.ReportListView_SelectedIndexChanged);
            // 
            // ReportID
            // 
            this.ReportID.Text = "ID";
            this.ReportID.Width = 50;
            // 
            // PatientID
            // 
            this.PatientID.Text = "PatientID";
            this.PatientID.Width = 214;
            // 
            // PatientName
            // 
            this.PatientName.Text = "PatientName";
            this.PatientName.Width = 256;
            // 
            // LaboratorianName
            // 
            this.LaboratorianName.Text = "LaboratorianName";
            this.LaboratorianName.Width = 205;
            // 
            // ReportName
            // 
            this.ReportName.Text = "ReportName";
            this.ReportName.Width = 224;
            // 
            // UploadDate
            // 
            this.UploadDate.Text = "Date";
            this.UploadDate.Width = 215;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 152;
            // 
            // ViewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 747);
            this.Controls.Add(this.ReportListView);
            this.Name = "ViewReportForm";
            this.Text = "ViewReportForm";
            this.Load += new System.EventHandler(this.ViewReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ReportListView;
        private System.Windows.Forms.ColumnHeader ReportID;
        private System.Windows.Forms.ColumnHeader PatientID;
        private System.Windows.Forms.ColumnHeader PatientName;
        private System.Windows.Forms.ColumnHeader LaboratorianName;
        private System.Windows.Forms.ColumnHeader ReportName;
        private System.Windows.Forms.ColumnHeader UploadDate;
        private System.Windows.Forms.ColumnHeader Description;
    }
}