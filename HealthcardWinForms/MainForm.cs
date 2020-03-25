using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcardWinForms.Models;
using HealthcardWinForms.GlobalInfos;
namespace HealthcardWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(loginButton.Text == "Logout")
            {
                
                    UserInfo.UserEmail = null;
                    UserInfo.UserName = null;
                    UserInfo.UserType = null;
                    Close();
                   
            }
           using(var databaseContext = new DatabaseContext())
            {
                User user = databaseContext.Users.Where(u => u.Email == emailTextBox.Text.ToString()).FirstOrDefault<User>();

                if(user == null)
                {
                    MessageBox.Show("User with email "+ emailTextBox.Text.ToString() + " not found");
                }
                else
                {
                    //Decryption of password
                    byte[] data = Convert.FromBase64String(user.Password.ToString());
                    byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
                    if(Encoding.Unicode.GetString(decrypted) == passwordTextBox.Text.ToString())
                    {
                        // Managing session
                        MessageBox.Show("Logging In to the app...", "Authenticated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserInfo.UserEmail = user.Email.ToString();
                        UserInfo.UserName = user.Firstname.ToString();
                        UserInfo.UserType = user.UserType.ToString();
                        UserInfo.UserID = user.UniqueID.ToString();
                        UserInfo.UserLastName = user.Lastname.ToString();

                        emailTextBox.Clear();
                        passwordTextBox.Clear();


                        if (UserInfo.UserEmail != null)
                        {
                            loginButton.Text = "Logout";
                            emailTextBox.Enabled = false;
                            passwordTextBox.Enabled = false;
                            registerButton.Enabled = false;
                        }

                        if (UserInfo.UserID.StartsWith("D"))
                        {
                            DocDetails docDetails = databaseContext.DocDetails.Where(a => a.Doctor == UserInfo.UserEmail).FirstOrDefault<DocDetails>();
                            if (docDetails == null)
                            {
                                DocExtraDetails docExtraDetails = new DocExtraDetails();
                                docExtraDetails.Tag = this;
                                docExtraDetails.ShowDialog(this);
                                //this.Enabled = false;

                            }
                            else
                            {
                                HomeForm homeForm = new HomeForm();
                                homeForm.Tag = this;
                                homeForm.ShowDialog(this);
                                //this.Enabled = false;

                            }
                        }
                        else
                        {
                            PatientHomeForm patientHomeForm = new PatientHomeForm();
                            patientHomeForm.Tag = this;
                            patientHomeForm.ShowDialog(this);
                        }

                        //Redirecting to Home Form if user gets logged in.

                    } 
                    else
                    {
                        MessageBox.Show("Couldn't Sign in to the app, make sure credentials are valid", "Failed to Authenticate", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordTextBox.Focus();
                    }
                }
            } 
        }

        private void LogInLabel_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Tag = this;
            registerForm.ShowDialog(this);
            
            
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            //this.Enabled = NavigationInfo.IsMainFrameEnabled ? true : false;

        }
    }
}
