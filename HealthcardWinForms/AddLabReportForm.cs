using HealthcardWinForms.GlobalInfos;
using HealthcardWinForms.Models;
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
    public partial class AddLabReportForm : Form
    {
         string fileName = string.Empty;

        public AddLabReportForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150); 
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                label1.Text = fileName;
            }
        }

        private void SaveReportButton_Click(object sender, EventArgs e)
        {
            byte[] file;
            //try
            //{
            //    string installedPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")) 
            //        + "reports";
            //    if (!System.IO.Directory.Exists(installedPath))
            //    {
            //        MessageBox.Show("Path is being created.!");
            //        System.IO.Directory.CreateDirectory(installedPath);
            //    }
            //    string destinationFileName = System.IO.Path.Combine(installedPath, System.IO.Path.GetFileName(fileName));
            //    System.IO.File.Copy(fileName, destinationFileName);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            try
            {
                using(var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using(var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }
                using(DatabaseContext databaseContext = new DatabaseContext())
                {
                    var report = new Report()
                    {
                        Content = file,
                        LaboratorianID = UserInfo.UserID,
                        LabName = UserInfo.LaboratorianLabName,
                        LaboratorianName = UserInfo.UserName + " " + UserInfo.UserLastName,
                        PathTOReport = "none",
                        PatientName = ForPatientTextBox.Text.ToString().Split('(')[0],
                        PatientID = ForPatientTextBox.Text.ToString().Split('(', ')')[1],
                        ReportDescription = ReportDescriptionRichTextBox.Text.ToString(),
                        ReportName = ReportNameTextBox.Text.ToString(),
                        UploadDate = DateTime.Now.ToShortDateString()

                    };
                    databaseContext.Reports.Add(report);
                    databaseContext.SaveChanges();
                    MessageBox.Show("Uploaded");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " file store" + ex.ToString());
            }
            
        }

        private void AddLabReportForm_Load(object sender, EventArgs e)
        {
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                var list = databaseContext.Users.Where(u => u.UniqueID.StartsWith("P")).ToList();

                foreach (var name in list)
                {
                    autoCompleteStringCollection.Add(name.Firstname + " " + name.Lastname + " (" + name.UniqueID + ")");
                }
                ForPatientTextBox.AutoCompleteCustomSource = autoCompleteStringCollection;

            }
            
        }
    }
}
