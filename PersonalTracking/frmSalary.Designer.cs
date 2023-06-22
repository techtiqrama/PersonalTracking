namespace PersonalTracking
{
    partial class frmSalary
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
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
            txtSalary = new TextBox();
            label6 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            cmbMonth = new ComboBox();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(336, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 398);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(218, 260);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbPosition);
            panel2.Controls.Add(cmbDepartment);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 138);
            panel2.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(14, 89);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(191, 29);
            cmbPosition.TabIndex = 1;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(14, 33);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(191, 29);
            cmbDepartment.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 65);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 16;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 9);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 15;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSurname.Location = new Point(120, 76);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(191, 29);
            txtSurname.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(120, 41);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(191, 29);
            txtName.TabIndex = 15;
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNo.Location = new Point(120, 6);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(191, 29);
            txtUserNo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 16;
            label3.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 12;
            label9.Text = "UserNo";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalary.Location = new Point(120, 111);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(191, 29);
            txtSalary.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 115);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 19;
            label6.Text = "Salary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 19;
            label1.Text = "Year";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(120, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 29);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 185);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 16;
            label7.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(120, 181);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(191, 29);
            cmbMonth.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(161, 337);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 50);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(5, 337);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSalary
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 398);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(cmbMonth);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtUserNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtUserNo;
        private Label label3;
        private Label label2;
        private Label label9;
        private ComboBox cmbPosition;
        private ComboBox cmbDepartment;
        private Label label5;
        private Label label4;
        private TextBox txtSalary;
        private Label label6;
        private Label label1;
        private TextBox textBox1;
        private Label label7;
        private ComboBox cmbMonth;
        private Button btnClose;
        private Button btnSave;
    }
}