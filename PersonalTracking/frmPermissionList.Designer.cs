namespace PersonalTracking
{
    partial class frmPermissionList
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
            rbDeliveryDate = new RadioButton();
            rbStartDate = new RadioButton();
            dpEnd = new DateTimePicker();
            dpStart = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            txtDayAmount = new TextBox();
            label8 = new Label();
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
            btnDisapprove = new Button();
            btnApprove = new Button();
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
            panel1.Size = new Size(783, 194);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dpEnd);
            panel3.Controls.Add(dpStart);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtDayAmount);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(341, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 194);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(276, 154);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 30);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(276, 118);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 30);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDeliveryDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(280, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 94);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // rbDeliveryDate
            // 
            rbDeliveryDate.AutoSize = true;
            rbDeliveryDate.Location = new Point(14, 56);
            rbDeliveryDate.Name = "rbDeliveryDate";
            rbDeliveryDate.Size = new Size(119, 23);
            rbDeliveryDate.TabIndex = 1;
            rbDeliveryDate.TabStop = true;
            rbDeliveryDate.Text = "Delivery Date";
            rbDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            rbStartDate.AutoSize = true;
            rbStartDate.Location = new Point(14, 27);
            rbStartDate.Name = "rbStartDate";
            rbStartDate.Size = new Size(94, 23);
            rbStartDate.TabIndex = 0;
            rbStartDate.TabStop = true;
            rbStartDate.Text = "Start Date";
            rbStartDate.UseVisualStyleBackColor = true;
            // 
            // dpEnd
            // 
            dpEnd.Location = new Point(67, 76);
            dpEnd.Name = "dpEnd";
            dpEnd.Size = new Size(190, 29);
            dpEnd.TabIndex = 1;
            // 
            // dpStart
            // 
            dpStart.Location = new Point(67, 41);
            dpStart.Name = "dpStart";
            dpStart.Size = new Size(190, 29);
            dpStart.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 79);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 11;
            label7.Text = "Finish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 44);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 9;
            label6.Text = "Start";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 8;
            label1.Text = "Permission Date";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDayAmount.Location = new Point(114, 116);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.Size = new Size(143, 29);
            txtDayAmount.TabIndex = 2;
            txtDayAmount.KeyPress += txtDayAmount_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 120);
            label8.Name = "label8";
            label8.Size = new Size(106, 21);
            label8.TabIndex = 10;
            label8.Text = "Day Amount";
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
            pnlForAdmin.Size = new Size(341, 194);
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
            txtUserNo.KeyPress += txtUserNo_KeyPress;
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
            panel2.Controls.Add(btnDisapprove);
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 493);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 57);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(629, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 44);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(511, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 44);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(393, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDisapprove
            // 
            btnDisapprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisapprove.Location = new Point(39, 6);
            btnDisapprove.Name = "btnDisapprove";
            btnDisapprove.Size = new Size(112, 44);
            btnDisapprove.TabIndex = 1;
            btnDisapprove.Text = "Disapprove";
            btnDisapprove.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.Location = new Point(157, 6);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(112, 44);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(275, 6);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 44);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(783, 299);
            dataGridView1.TabIndex = 2;
            // 
            // frmPermissionList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 550);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmPermissionList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission List";
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
        private Button btnDisapprove;
        private Button btnApprove;
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
        private RadioButton rbDeliveryDate;
        private RadioButton rbStartDate;
        private DateTimePicker dpEnd;
        private DateTimePicker dpStart;
        private Label label7;
        private Label label6;
        private Label label1;
        private TextBox txtDayAmount;
        private Label label8;
        private Button btnClear;
        private Button btnSearch;
    }
}