using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class frmSalaryList : Form
    {
        public frmSalaryList()
        {
            InitializeComponent();
        }

        private void rbEqual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmSalary frmSalary = new frmSalary();
            this.Hide();
            frmSalary.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmSalary frmSalary = new frmSalary();
            this.Hide();
            frmSalary.ShowDialog();
            this.Visible = true;
        }
    }
}
