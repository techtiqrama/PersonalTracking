namespace PersonalTracking
{
    partial class frmTask
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
            cmbTaskState = new ComboBox();
            label8 = new Label();
            label1 = new Label();
            txtTitle = new TextBox();
            label6 = new Label();
            txtContent = new TextBox();
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
            panel1.Location = new Point(432, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 417);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(220, 271);
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
            panel2.Size = new Size(220, 146);
            panel2.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(15, 89);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(191, 29);
            cmbPosition.TabIndex = 1;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(15, 33);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(191, 29);
            cmbDepartment.TabIndex = 0;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 65);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 12;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 9);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 10;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSurname.Location = new Point(120, 87);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(191, 29);
            txtSurname.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(120, 52);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(191, 29);
            txtName.TabIndex = 9;
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNo.Location = new Point(120, 17);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(191, 29);
            txtUserNo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 10;
            label3.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 20);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 6;
            label9.Text = "UserNo";
            // 
            // cmbTaskState
            // 
            cmbTaskState.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(120, 122);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(191, 29);
            cmbTaskState.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 125);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 12;
            label8.Text = "Task State";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 159);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 10;
            label1.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(120, 157);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(191, 29);
            txtTitle.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 194);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 10;
            label6.Text = "Content";
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContent.Location = new Point(120, 192);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(306, 157);
            txtContent.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(276, 355);
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
            btnSave.Location = new Point(120, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmTask
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 417);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(cmbTaskState);
            Controls.Add(label8);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(txtSurname);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtUserNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
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
        private ComboBox cmbTaskState;
        private Label label8;
        private Label label1;
        private TextBox txtTitle;
        private Label label6;
        private TextBox txtContent;
        private Button btnClose;
        private Button btnSave;
    }
}