using HealthcardWinForms.GlobalInfos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcardWinForms.Models;
using System.Collections;

namespace HealthcardWinForms
{
    public partial class PrescriptionForm : Form
    {
        long RandNumber = 0;
        public PrescriptionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
            
        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                Random random = new Random();
                RandNumber = random.Next(5556, 55343);

                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                var list = databaseContext.Users.Where(u => u.UniqueID.StartsWith("P")).ToList();

                foreach(var name in list)
                {
                    autoCompleteStringCollection.Add(name.Firstname + " " + name.Lastname + " (" + name.UniqueID + ")");
                }
                ToPatientTextBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            }
        }

        private void PrescriptionSaveButton_Click(object sender, EventArgs e)
        {
            Medicine medicine = null;

            DateTime dateTime = DateTime.Now;
            //string time = dateTime.ToShortTimeString();
            string date = dateTime.ToShortDateString();

            //MessageBox.Show(); 
            int morningDose = 0, afternoonDose = 0, nightDose = 0;
            string morningGroupBoxValue = "", afternoonGroupBoxValue = "", nightGroupBoxValue = "", patientID = "", medicineName = "";
            try
            {
                
                medicineName = MedicineNameTextBox.Text.ToString();
                morningGroupBoxValue = MorningDoseGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
                afternoonGroupBoxValue = AfternoonGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Split('_')[1];
                nightGroupBoxValue = NightDoseGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Split('_')[1];
                patientID = ToPatientTextBox.Text.ToString().Split('(', ')')[1];
                UserInfo.TempPatientIDForDoctor = patientID;
                UserInfo.medicineIDHelper = patientID + RandNumber + date;

            }

            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter the patient name in respective field.", "ValidationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { }
            
            //MessageBox.Show(afternoonGroupBoxValue);
            //switch(morningGroupBoxValue)
            //{
            //    case "one":
            //        morningDose = 1;
            //        break;
            //    case "two":
            //        morningDose = 2;
            //        break;
            //    case "three":
            //        morningDose = 3;
            //        break;
            //    case "four":
            //        morningDose = 4;
            //        break;
            //    default:
            //        morningDose = 0;
            //        break;
            //}
            Hashtable hashtable = new Hashtable();
            hashtable.Add("zero", 0);
            hashtable.Add("one", 1);
            hashtable.Add("two", 2);
            hashtable.Add("three", 3);
            hashtable.Add("four", 4);

            foreach(DictionaryEntry item in hashtable)
            {
                if(morningGroupBoxValue == item.Key.ToString())
                {
                    morningDose = (int) item.Value;

                }
                if(afternoonGroupBoxValue == item.Key.ToString())
                {
                    afternoonDose = (int)item.Value;
                }
                if(nightGroupBoxValue == item.Key.ToString())
                {
                    nightDose = (int)item.Value;
                }
            }
            //MessageBox.Show(morningDose.ToString() + " " + afternoonDose.ToString() + " " + nightDose.ToString());
           
            try
            {
                using(DatabaseContext databaseContext = new DatabaseContext())
                {
                    medicine = new Medicine();
                    medicine.AfterNoonDose = afternoonDose;
                    medicine.Days = Convert.ToInt32(DaysTextBox.Text);
                    medicine.UniqueMedicineID = UserInfo.medicineIDHelper;
                    medicine.MorningDose = morningDose;
                    medicine.NightDose = nightDose;
                    medicine.MedicineName = MedicineNameTextBox.Text.ToString();
                    databaseContext.Medicines.Add(medicine);
                    databaseContext.SaveChanges();

                }
                MessageBox.Show("Medicine " + MedicineNameTextBox.Text.ToString() + " stored in current prescription", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MedicineNameTextBox.Clear();
                DaysTextBox.Clear();
                MedicineNameTextBox.Focus();


            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Occured" + ex.ToString());
            }
             
        }

        private void PrescriptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                MessageBox.Show("Whole Prescription has been saved successfully.!" , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Prescription prescription = new Prescription();
                prescription.MedicineID = UserInfo.medicineIDHelper;
                prescription.PatientID = UserInfo.TempPatientIDForDoctor;
                prescription.DoctorEmail = UserInfo.UserEmail;
                prescription.PatientName = ToPatientTextBox.Text.ToString().Split('(')[0];
                prescription.DoctorHospital = UserInfo.DoctorHospitalName;
                prescription.DoctorName = UserInfo.UserName + " " + UserInfo.UserLastName;
                //MessageBox.Show(prescription.PatientName + " " + UserInfo.DoctorHospitalName);
                databaseContext.Prescriptions.Add(prescription);
                databaseContext.SaveChanges();
            }
        }

        private void PrescriptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserInfo.TempPatientIDForDoctor = null;
            UserInfo.medicineIDHelper = null;
        }
    }
}
