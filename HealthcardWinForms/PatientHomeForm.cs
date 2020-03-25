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

namespace HealthcardWinForms
{
    public partial class PatientHomeForm : Form
    {
        public PatientHomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
            UsernameLabel.Text = UserInfo.UserName;

        }
    }
}
