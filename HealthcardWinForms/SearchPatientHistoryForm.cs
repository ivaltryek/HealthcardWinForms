using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcardWinForms
{
    public partial class SearchPatientHistoryForm : Form
    {
        public SearchPatientHistoryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
        }

        private void SearchPatientHistoryForm_Load(object sender, EventArgs e)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
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

        private void prescriptionSearchButton_Click(object sender, EventArgs e)
        {
            string patientID = ForPatientTextBox.Text.ToString().Split('(', ')')[1];
            ViewPrescriptionForm viewPrescriptionForm = new ViewPrescriptionForm();
            viewPrescriptionForm.ViewPatientPrescriptionForDoctor(patientID);
            viewPrescriptionForm.Tag = this;
            viewPrescriptionForm.ShowDialog(this);

        }
    }
}
