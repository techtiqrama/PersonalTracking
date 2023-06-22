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
    public partial class frmTaskList : Form
    {
        public frmTaskList()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaskList_Load(object sender, EventArgs e)
        {
            pnlForAdmin.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTask frmTask = new frmTask();
            this.Hide();
            frmTask.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmTask frmTask = new frmTask();
            this.Hide();
            frmTask.ShowDialog();
            this.Visible = true;
        }
    }
}
