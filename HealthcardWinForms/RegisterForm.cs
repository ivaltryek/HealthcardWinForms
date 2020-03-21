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
                return;
            }
            
        }

        
    }
}
