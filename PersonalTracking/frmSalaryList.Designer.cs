namespace PersonalTracking
{
    partial class frmSalaryList
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
            panel3 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            rbEqual = new RadioButton();
            rbLess = new RadioButton();
            rbMore = new RadioButton();
            cmbMonth = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            txtSalary = new TextBox();
            label6 = new Label();
            pnlForAdmin = new Panel();
            cmbPosition = new ComboBox();
            cmbDepartment = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtUserNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 241);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(cmbMonth);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtSalary);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(329, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 241);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(162, 185);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 50);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(6, 185);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 50);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEqual);
            groupBox1.Controls.Add(rbLess);
            groupBox1.Controls.Add(rbMore);
            groupBox1.Location = new Point(50, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 61);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // rbEqual
            // 
            rbEqual.AutoSize = true;
            rbEqual.Location = new Point(145, 30);
            rbEqual.Name = "rbEqual";
            rbEqual.Size = new Size(71, 25);
            rbEqual.TabIndex = 2;
            rbEqual.TabStop = true;
            rbEqual.Text = "Equal";
            rbEqual.UseVisualStyleBackColor = true;
            rbEqual.CheckedChanged += rbEqual_CheckedChanged;
            // 
            // rbLess
            // 
            rbLess.AutoSize = true;
            rbLess.Location = new Point(80, 30);
            rbLess.Name = "rbLess";
            rbLess.Size = new Size(59, 25);
            rbLess.TabIndex = 1;
            rbLess.TabStop = true;
            rbLess.Text = "Less";
            rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            rbMore.AutoSize = true;
            rbMore.Location = new Point(6, 30);
            rbMore.Name = "rbMore";
            rbMore.Size = new Size(68, 25);
            rbMore.TabIndex = 0;
            rbMore.TabStop = true;
            rbMore.Text = "More";
            rbMore.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(114, 40);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(191, 29);
            cmbMonth.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(114, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 29);
            textBox1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 44);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 23;
            label7.Text = "Month";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 24;
            label1.Text = "Year";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalary.Location = new Point(114, 75);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(191, 29);
            txtSalary.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 79);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 25;
            label6.Text = "Salary";
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(cmbPosition);
            pnlForAdmin.Controls.Add(cmbDepartment);
            pnlForAdmin.Controls.Add(label5);
            pnlForAdmin.Controls.Add(label4);
            pnlForAdmin.Controls.Add(txtSurname);
            pnlForAdmin.Controls.Add(txtName);
            pnlForAdmin.Controls.Add(txtUserNo);
            pnlForAdmin.Controls.Add(label3);
            pnlForAdmin.Controls.Add(label2);
            pnlForAdmin.Controls.Add(label9);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(329, 241);
            pnlForAdmin.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(120, 146);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(191, 29);
            cmbPosition.TabIndex = 4;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(120, 111);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(191, 29);
            cmbDepartment.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 149);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 18;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 16;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSurname.Location = new Point(120, 76);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(191, 29);
            txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(120, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 29);
            txtName.TabIndex = 1;
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNo.Location = new Point(120, 6);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(191, 29);
            txtUserNo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 14;
            label3.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 10;
            label9.Text = "UserNo";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 58);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(455, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 44);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(337, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(219, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(101, 6);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 44);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(655, 209);
            dataGridView1.TabIndex = 0;
            // 
            // frmSalaryList
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 508);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmSalaryList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary List";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            pnlForAdmin.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private Panel panel3;
        private Panel pnlForAdmin;
        private ComboBox cmbPosition;
        private ComboBox cmbDepartment;
        private Label label5;
        private Label label4;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtUserNo;
        private Label label3;
        private Label label2;
        private Label label9;
        private GroupBox groupBox1;
        private ComboBox cmbMonth;
        private TextBox textBox1;
        private Label label7;
        private Label label1;
        private TextBox txtSalary;
        private Label label6;
        private RadioButton rbEqual;
        private RadioButton rbLess;
        private RadioButton rbMore;
        private Button btnClear;
        private Button btnSearch;
    }
}