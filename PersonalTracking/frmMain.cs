﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeList frm = new frmEmployeeList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            frmTaskList frm = new frmTaskList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmSalaryList frm = new frmSalaryList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            frmPermissionList frm = new frmPermissionList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepartmentList frm = new frmDepartmentList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmPositionList frm = new frmPositionList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
