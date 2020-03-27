using HealthcardWinForms.GlobalInfos;
using HealthcardWinForms.Models;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcardWinForms
{
    public partial class ViewReportForm : Form
    {
        public ViewReportForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
        }

        private void ViewReportForm_Load(object sender, EventArgs e)
        {

        }
        public void ViewReportsOfLaboratorian()
        {
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                try
                {
                    var reportlist = databaseContext.Reports.Where(r => r.LaboratorianID == UserInfo.UserID).ToList();
                    if(!reportlist.Any())
                    {
                        MessageBox.Show("It seems there's no report found which was uploaded by you!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    foreach(var rItem in reportlist)
                    {
                        ListViewItem listViewItem = new ListViewItem(rItem.ID.ToString());
                        listViewItem.SubItems.Add(rItem.PatientID);
                        listViewItem.SubItems.Add(rItem.PatientName);
                        listViewItem.SubItems.Add(rItem.LaboratorianName);
                        listViewItem.SubItems.Add(rItem.ReportName);
                        listViewItem.SubItems.Add(rItem.UploadDate);
                        listViewItem.SubItems.Add(rItem.ReportDescription);
                        ReportListView.Items.Add(listViewItem);
                    }
                    
                }
                catch(Exception)
                {

                }
            }
        }

        private void ReportListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ReportListView.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = ReportListView.SelectedItems[0];
                int id = Convert.ToInt32(listViewItem.SubItems[0].Text);
                //MessageBox.Show(id.ToString());
                using(DatabaseContext databaseContext = new DatabaseContext())
                {
                    var report = databaseContext.Reports.Where(r => r.ID == id).FirstOrDefault();
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Save Report";
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //PdfDocument pdfDocument = new PdfDocument();
                        //byte [] file = 
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName + ".pdf", report.Content);
                    }
                  
                    
                }
            }
        }
    }
}
