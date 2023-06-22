namespace PersonalTracking
{
    partial class frmTaskList
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
            cmbTaskState = new ComboBox();
            groupBox1 = new GroupBox();
            rbDeliveryDate = new RadioButton();
            rbStartDate = new RadioButton();
            dpEnd = new DateTimePicker();
            label8 = new Label();
            dpStart = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
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
            panel1.Size = new Size(775, 216);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(cmbTaskState);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dpEnd);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dpStart);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(338, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 216);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(162, 160);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 50);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(6, 160);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 50);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbTaskState
            // 
            cmbTaskState.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(108, 119);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(149, 29);
            cmbTaskState.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDeliveryDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(280, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 94);
            groupBox1.TabIndex = 7;
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
            dpEnd.Location = new Point(67, 84);
            dpEnd.Name = "dpEnd";
            dpEnd.Size = new Size(190, 29);
            dpEnd.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 122);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 5;
            label8.Text = "Task State";
            // 
            // dpStart
            // 
            dpStart.Location = new Point(67, 49);
            dpStart.Name = "dpStart";
            dpStart.Size = new Size(190, 29);
            dpStart.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 87);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 3;
            label7.Text = "Finish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 52);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 1;
            label6.Text = "Start";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Task Date";
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
            pnlForAdmin.Size = new Size(338, 216);
            pnlForAdmin.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(129, 154);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(191, 29);
            cmbPosition.TabIndex = 9;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(129, 119);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(191, 29);
            cmbDepartment.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 157);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 8;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 122);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 6;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSurname.Location = new Point(129, 84);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(191, 29);
            txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(129, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 29);
            txtName.TabIndex = 3;
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNo.Location = new Point(129, 14);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(191, 29);
            txtUserNo.TabIndex = 1;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 86);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 4;
            label3.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(21, 17);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 0;
            label9.Text = "UserNo";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 508);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 58);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(572, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 44);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(454, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(336, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.Location = new Point(100, 6);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(112, 44);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(218, 6);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 44);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(775, 292);
            dataGridView1.TabIndex = 0;
            // 
            // frmTaskList
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 566);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmTaskList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task List";
            Load += frmTaskList_Load;
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
        private Button btnApprove;
        private Button btnNew;
        private Panel pnlForAdmin;
        private Panel panel3;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtUserNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbPosition;
        private ComboBox cmbDepartment;
        private Label label5;
        private Label label4;
        private DateTimePicker dpEnd;
        private DateTimePicker dpStart;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private RadioButton rbDeliveryDate;
        private RadioButton rbStartDate;
        private ComboBox cmbTaskState;
        private Label label8;
        private Button btnClear;
        private Button btnSearch;
        private Label label9;
    }
}