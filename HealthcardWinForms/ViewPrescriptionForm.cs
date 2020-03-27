using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcardWinForms.GlobalInfos;
namespace HealthcardWinForms
{
    public partial class ViewPrescriptionForm : Form
    {
        public ViewPrescriptionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
        }

        public  void ViewPrescriptionOfPatient()
        {
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                try
                {
                    var list = databaseContext.Prescriptions.Where(p => p.PatientID == UserInfo.UserID).ToList();
                    if(!list.Any())
                    {
                        MessageBox.Show("No Prescriptions Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    foreach (var pItem in list)
                    {
                        ListViewItem listViewItem = new ListViewItem(pItem.ID.ToString());
                        listViewItem.SubItems.Add(pItem.PatientID.ToString());
                        listViewItem.SubItems.Add(pItem.PatientName.ToString());
                        listViewItem.SubItems.Add(pItem.MedicineID.ToString());
                        listViewItem.SubItems.Add(pItem.Date.ToString());
                        PrescriptionListView.Items.Add(listViewItem);
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Exception Occurred at ViewPrescritionForPatient() " + ex.ToString());
                }
                

            }
        }

        public void ViewPrescriptionOfDoctor()
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                try
                {
                    var prescriptionList = databaseContext.Prescriptions.Where(p => p.DoctorEmail == UserInfo.UserEmail).ToList();
                    if (!prescriptionList.Any())
                    {
                        MessageBox.Show("No Prescriptions Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    foreach (var pItem in prescriptionList)
                    {
                        ListViewItem listViewItem = new ListViewItem(pItem.ID.ToString());
                        listViewItem.SubItems.Add(pItem.PatientID.ToString());
                        listViewItem.SubItems.Add(pItem.PatientName.ToString());
                        listViewItem.SubItems.Add(pItem.MedicineID.ToString());
                        listViewItem.SubItems.Add(pItem.Date.ToString());
                        PrescriptionListView.Items.Add(listViewItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void ViewPrescriptionForm_Load(object sender, EventArgs e)
        {
           
        }

        private void PrescriptionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            if(PrescriptionListView.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = PrescriptionListView.SelectedItems[0];
                string id = listViewItem.SubItems[3].Text;
                //MessageBox.Show(id);
                try
                {
                    using(DatabaseContext databaseContext = new DatabaseContext())
                    {
                        var medicineDetails = databaseContext.Medicines.Where(m => m.UniqueMedicineID == id).ToList();
                        foreach(var mDetail in medicineDetails)
                        {
                            MessageBox.Show("Medicine Name: " + mDetail.MedicineName + Environment.NewLine +
                                "Morning Dose: " + mDetail.MorningDose + Environment.NewLine +
                                "Afternoon Dose: " + mDetail.AfterNoonDose + Environment.NewLine + 
                                "Night Dose: " + mDetail.NightDose + Environment.NewLine +
                                "For Days: " + mDetail.Days + Environment.NewLine, mDetail.UniqueMedicineID, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something went wrong: " + ex.ToString());
                }

            }

        }
    }
}
