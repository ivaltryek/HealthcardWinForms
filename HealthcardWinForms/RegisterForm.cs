using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using HealthcardWinForms.Models;
namespace HealthcardWinForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainForm = (MainForm)Tag;
            mainForm.Show();
            // this.Close();
        }

       
        private void registerButton_Click(object sender, EventArgs e)
        {

           

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text.ToString()) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text.ToString()) ||
                string.IsNullOrWhiteSpace(userTypeComboBox.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(genderGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).ToString())
                || string.IsNullOrWhiteSpace(mobileTextBox.Text.ToString()) ||
                string.IsNullOrWhiteSpace(email.Text.ToString()) || 
                string.IsNullOrWhiteSpace(passwordTextBox.Text.ToString()) ||
                string.IsNullOrWhiteSpace(confirmPasswordtTextBox.Text.ToString()))
            {
                MessageBox.Show("All fields are required", "ValidationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                using (var databaseContext = new DatabaseContext())
                {
                    //Encryption of password
                    var data = Encoding.Unicode.GetBytes(confirmPasswordtTextBox.Text.ToString());
                    byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
                    string converted = Convert.ToBase64String(encrypted);



                   
                    try
                    {
                        var newUser = new User()
                        {
                            Firstname = firstNameTextBox.Text.ToString(),
                            Lastname = lastNameTextBox.Text.ToString(),
                            UserType = userTypeComboBox.SelectedItem.ToString(),
                            gender = genderGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name,
                            Mobile = mobileTextBox.Text.ToString(),
                            Email = email.Text.ToString(),
                            password = converted,
                            age = ageTextBox.Text.ToString()


                        };
                        databaseContext.Users.Add(newUser);
                        databaseContext.SaveChanges();
                        MessageBox.Show("You can close this window and Log into the system now!", "Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("User with email " + email.Text.ToString() + " does already exists", "Couldn't Registered", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

            }


            
            
        }

        private void mobileTextBox_Leave(object sender, EventArgs e)
        {
            if(long.TryParse(mobileTextBox.Text.ToString(), out long data))
            {
                int count = data.ToString().Count(char.IsDigit);
                if (count < 10)
                {
                    MessageBox.Show("Invalid mobile number. ", "ValidationError", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Mobile number are supposed to be in numbers.", "ValidationError", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                mobileTextBox.Focus();
            }
        }

        private void confirmPasswordtTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.ToString() != confirmPasswordtTextBox.Text.ToString())
            {
                MessageBox.Show("Passwords didn't matched!", "ValidationError", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void ageTextBox_Leave(object sender, EventArgs e)
        {
            if(long.TryParse(ageTextBox.Text.ToString() , out long age))
            {
                if(age > 100)
                {
                    MessageBox.Show("Don't fake your age, Reenter again please.", "FakeAgeError", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Age are supposed to count in numbers, Right?", "FakeAgeError", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                ageTextBox.Focus();
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            Regex regexpr;
            if(email.Text.Trim() != string.Empty)
            {
                regexpr = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if(!regexpr.IsMatch(email.Text.Trim()))
                {
                    MessageBox.Show("Email is not in proper format", "ValidateEmailError", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    email.Focus();
                }
            }
        }

        private void genderGroupBox_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show(genderGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name);

        }
    }
}
