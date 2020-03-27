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
using HealthcardWinForms.GlobalInfos;
namespace HealthcardWinForms
{
    public partial class LaboratorianExtraDetailsForm : Form
    {
        public LaboratorianExtraDetailsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
            this.ControlBox = false;
        }

        private void InfoSaveButton_Click(object sender, EventArgs e)
        {
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                try
                {
                    var laboratorianDetails = new LaboratorianDetail()
                    {
                        AddressLine1 = WorkPlaceAddressLine1TextBox.Text.ToString(),
                        AddressLine2 = WorkPlaceAddressLine2TextBox.Text.ToString(),
                        AddressLine3 = WorkPlaceAddressLine3TextBox.Text.ToString(),
                        Degree = DegreeTextBox.Text.ToString(),
                        Laboratorian = UserInfo.UserEmail,
                        LicenceNo = LicenceTextBox.Text.ToString(),
                        State = StateTextBox.Text.ToString(),
                        WorkPlace = WorkPlaceTextBox.Text.ToString(),
                        WorkPlaceContact = WorkPlaceContactTextBox.Text.ToString(),
                        ZipCode = ZipCodeTextBox.Text.ToString()
                    };
                    databaseContext.LaboratorianDetails.Add(laboratorianDetails);
                    databaseContext.SaveChanges();
                    MessageBox.Show("Details are saved, this windows will close now to continue further.", "SuccessValidation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Exception Occured while saving LabDetails:  " + ex.ToString()); 
                }
            }

        }

        private void WorkPlaceContactTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void ZipCodeTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void LaboratorianExtraDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
