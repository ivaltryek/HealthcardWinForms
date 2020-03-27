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

    public partial class DocExtraDetails : Form
    {

       public DocExtraDetails()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
            this.ControlBox = false;
        }

        private void DocExtraDetails_Load(object sender, EventArgs e)
        {

        }

        private void InfoSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var databaseContext = new DatabaseContext())
                {
                    var details = new DocDetails()
                    {
                        AddressLine1 = WorkPlaceAddressLine1TextBox.Text.ToString(),
                        AddressLine2 = WorkPlaceAddressLine2TextBox.Text.ToString(),
                        AddressLine3 = WorkPlaceAddressLine3TextBox.Text.ToString(),
                        Degree = DegreeTextBox.Text.ToString(),
                        Doctor = UserInfo.UserEmail.ToString(),
                        IsVerified = false,
                        LicenceNo = LicenceTextBox.Text.ToString(),
                        Specialities = SpecialityTextBox.Text.ToString(),
                        State = StateTextBox.Text.ToString(),
                        WorkPlace = WorkPlaceTextBox.Text.ToString(),
                        WorkPlaceContact = WorkPlaceContactTextBox.Text.ToString(),
                        ZipCode = ZipCodeTextBox.Text.ToString(),


                    };
                    databaseContext.DocDetails.Add(details);
                    databaseContext.SaveChanges();
                    MessageBox.Show("Details are saved, this windows will close now to continue further.", "SuccessValidation", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch(System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                MessageBox.Show("It seems some fields are left blank, make sure to fill them up before saving", "FieldRequiredValidation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DocExtraDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            var homeform = new HomeForm();
            homeform.ShowDialog();
        }

        public void ZipCodeTextBox_Leave(object sender, EventArgs e)
        {
            if(long.TryParse(ZipCodeTextBox.Text.ToString(), out long zip))
            {
                if(zip.ToString().Count() > 6)
                {
                    MessageBox.Show("It seems you have entered wrong zip", "ValidationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zipcode are supposed to be in numbers. Please Reenter again.!", "ValidationError", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
