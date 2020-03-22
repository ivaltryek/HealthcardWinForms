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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void LoginButton_Click(object sender, EventArgs e)
        {
           using(var databaseContext = new DatabaseContext())
            {
                User user = databaseContext.Users.Where(u => u.Email == emailTextBox.Text.ToString()).FirstOrDefault<User>();
                if(user == null)
                {
                    MessageBox.Show("User with email "+ emailTextBox.Text.ToString() + "not found");
                }
                else
                {
                    //Decryption of password
                    byte[] data = Convert.FromBase64String(user.password.ToString());
                    byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
                    if(Encoding.Unicode.GetString(decrypted) == passwordTextBox.Text.ToString())
                    {
                        // Managing session
                        MessageBox.Show("Logging In to the app...", "Authenticated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserInfo.UserEmail = user.Email.ToString();
                        UserInfo.UserName = user.Firstname.ToString();
                        UserInfo.UserType = user.UserType.ToString();

                        emailTextBox.Clear();
                        passwordTextBox.Clear();

                        //Redirecting to Home Form if user gets logged in.
                        HomeForm homeForm = new HomeForm();
                        homeForm.Tag = this;
                        homeForm.Show(this);
                        Hide();
                    } 
                    else
                    {
                        MessageBox.Show("Couldn't Sign in to the app, make sure credentials are valid", "Failed to Authenticate", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            registerForm.Show(this);
            Hide();
            
        }
    }
}
