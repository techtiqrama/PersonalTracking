namespace PersonalTracking
{
    partial class frmEmployee
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
            panel1 = new Panel();
            chAdmin = new CheckBox();
            btnCheck = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse = new Button();
            label6 = new Label();
            txtSalary = new TextBox();
            cmbDepartment = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cmbPosition = new ComboBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            txtAddress = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chAdmin);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUserNo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 75);
            panel1.TabIndex = 0;
            // 
            // chAdmin
            // 
            chAdmin.AutoSize = true;
            chAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chAdmin.Location = new Point(677, 23);
            chAdmin.Name = "chAdmin";
            chAdmin.Size = new Size(103, 25);
            chAdmin.TabIndex = 3;
            chAdmin.Text = "Is Admin?";
            chAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck.Location = new Point(273, 21);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(100, 29);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(480, 21);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 29);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(398, 25);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNo.Location = new Point(76, 21);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(191, 29);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 4;
            label1.Text = "UserNo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 106);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(130, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 29);
            txtName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 141);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 2;
            label4.Text = "Surname";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(130, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 29);
            textBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 176);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 3;
            label5.Text = "Image Path";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(130, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 29);
            textBox2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(480, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 233);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.Location = new Point(306, 171);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 29);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 211);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 4;
            label6.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalary.Location = new Point(130, 207);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(170, 29);
            txtSalary.TabIndex = 4;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(130, 242);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(170, 29);
            cmbDepartment.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 243);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 5;
            label7.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(8, 278);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 6;
            label8.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(130, 277);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(170, 29);
            cmbPosition.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 313);
            label9.Name = "label9";
            label9.Size = new Size(81, 21);
            label9.TabIndex = 7;
            label9.Text = "Birthdate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 312);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(8, 345);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 8;
            label10.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(130, 341);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(636, 94);
            txtAddress.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(391, 462);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 50);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(235, 462);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 528);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbPosition);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cmbDepartment);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(btnBrowse);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label10);
            Controls.Add(txtName);
            Controls.Add(label3);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCheck;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUserNo;
        private Label label1;
        private CheckBox chAdmin;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse;
        private Label label6;
        private TextBox txtSalary;
        private ComboBox cmbDepartment;
        private Label label7;
        private Label label8;
        private ComboBox cmbPosition;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private TextBox txtAddress;
        private Button btnClose;
        private Button btnSave;
    }
}