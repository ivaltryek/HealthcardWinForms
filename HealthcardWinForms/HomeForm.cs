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
    }
}
