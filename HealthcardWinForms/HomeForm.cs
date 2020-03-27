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
using HealthcardWinForms.Models;
namespace HealthcardWinForms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
            UsernameLabel.Text = UserInfo.UserName;
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                DocDetails docDetails = databaseContext.DocDetails.Where(e => e.Doctor == UserInfo.UserEmail).FirstOrDefault<DocDetails>();
                UserInfo.IsInfoFilled = docDetails == null ? false : true;
                UserInfo.DoctorHospitalName = UserInfo.IsInfoFilled == true ? docDetails.WorkPlace.ToString() : null;
                
            }
             
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
          
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_mainForm.Enabled = true;
        }

        private void HomeForm_Enter(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!UserInfo.IsInfoFilled)
            {
                MessageBox.Show("It seems you didn't completed your profile, please finish it first then try again.", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
            }
            else
            {
                PrescriptionForm prescriptionForm = new PrescriptionForm();
                prescriptionForm.Tag = this;
                prescriptionForm.ShowDialog(this);
            }
        }

        private void myWrittenPrescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPrescriptionForm viewPrescriptionForm = new ViewPrescriptionForm();
            viewPrescriptionForm.Tag = this;
            viewPrescriptionForm.ViewPrescriptionOfDoctor();
            viewPrescriptionForm.ShowDialog(this);
        }
    }
}
