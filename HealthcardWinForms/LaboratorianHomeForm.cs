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
    public partial class LaboratorianHomeForm : Form
    {
        string filename = string.Empty;
        public LaboratorianHomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
            UsernameLabel.Text = UserInfo.UserName;
        }

        private void LaboratorianHomeForm_Load(object sender, EventArgs e)
        {
          
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLabReportForm addLabReportForm = new AddLabReportForm();
            addLabReportForm.Tag = this;
            addLabReportForm.ShowDialog(this);
        }

        private void MyUploadedReports_Click(object sender, EventArgs e)
        {
            ViewReportForm viewReportForm = new ViewReportForm();
            viewReportForm.ViewReportsOfLaboratorian();
            viewReportForm.Tag = this;
            viewReportForm.ShowDialog(this);
        }
    }
}
