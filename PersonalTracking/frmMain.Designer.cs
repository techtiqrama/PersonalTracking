namespace PersonalTracking
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnEmployee = new Button();
            btnTask = new Button();
            btnSalary = new Button();
            btnPermission = new Button();
            btnDepartment = new Button();
            btnPosition = new Button();
            btnLogOut = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Aqua;
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.Image = Properties.Resources.user_group;
            btnEmployee.ImageAlign = ContentAlignment.TopCenter;
            btnEmployee.Location = new Point(12, 12);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(150, 150);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.TextAlign = ContentAlignment.BottomCenter;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnTask
            // 
            btnTask.BackColor = Color.SkyBlue;
            btnTask.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTask.Image = (Image)resources.GetObject("btnTask.Image");
            btnTask.ImageAlign = ContentAlignment.TopCenter;
            btnTask.Location = new Point(168, 12);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(150, 150);
            btnTask.TabIndex = 1;
            btnTask.Text = "Task";
            btnTask.TextAlign = ContentAlignment.BottomCenter;
            btnTask.UseVisualStyleBackColor = false;
            btnTask.Click += btnTask_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.Gold;
            btnSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalary.Image = (Image)resources.GetObject("btnSalary.Image");
            btnSalary.ImageAlign = ContentAlignment.TopCenter;
            btnSalary.Location = new Point(324, 12);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(150, 150);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Salary ";
            btnSalary.TextAlign = ContentAlignment.BottomCenter;
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnPermission
            // 
            btnPermission.BackColor = Color.Green;
            btnPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPermission.Image = (Image)resources.GetObject("btnPermission.Image");
            btnPermission.ImageAlign = ContentAlignment.TopCenter;
            btnPermission.Location = new Point(12, 168);
            btnPermission.Name = "btnPermission";
            btnPermission.Size = new Size(150, 150);
            btnPermission.TabIndex = 3;
            btnPermission.Text = "Permission";
            btnPermission.TextAlign = ContentAlignment.BottomCenter;
            btnPermission.UseVisualStyleBackColor = false;
            btnPermission.Click += btnPermission_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.SkyBlue;
            btnDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartment.Image = (Image)resources.GetObject("btnDepartment.Image");
            btnDepartment.ImageAlign = ContentAlignment.TopCenter;
            btnDepartment.Location = new Point(168, 168);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(150, 150);
            btnDepartment.TabIndex = 4;
            btnDepartment.Text = "Department";
            btnDepartment.TextAlign = ContentAlignment.BottomCenter;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnPosition
            // 
            btnPosition.BackColor = Color.LightYellow;
            btnPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPosition.Image = (Image)resources.GetObject("btnPosition.Image");
            btnPosition.ImageAlign = ContentAlignment.TopCenter;
            btnPosition.Location = new Point(324, 168);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(150, 150);
            btnPosition.TabIndex = 5;
            btnPosition.Text = "Position";
            btnPosition.TextAlign = ContentAlignment.BottomCenter;
            btnPosition.UseVisualStyleBackColor = false;
            btnPosition.Click += btnPosition_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.SkyBlue;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.TopCenter;
            btnLogOut.Location = new Point(86, 324);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(150, 150);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "LogOut";
            btnLogOut.TextAlign = ContentAlignment.BottomCenter;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.BackColor = Color.FloralWhite;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.TopCenter;
            btnExit.Location = new Point(242, 324);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 150);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 494);
            Controls.Add(btnExit);
            Controls.Add(btnLogOut);
            Controls.Add(btnPosition);
            Controls.Add(btnDepartment);
            Controls.Add(btnPermission);
            Controls.Add(btnSalary);
            Controls.Add(btnTask);
            Controls.Add(btnEmployee);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employe Tracking";
            FormClosed += frmMain_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
        private Button btnTask;
        private Button btnSalary;
        private Button btnPermission;
        private Button btnDepartment;
        private Button btnPosition;
        private Button btnLogOut;
        private Button btnExit;
    }
}