namespace PersonalTracking
{
    partial class frmPermission
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
            txtUserNo = new TextBox();
            label9 = new Label();
            dpEnd = new DateTimePicker();
            dpStart = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            txtDayAmount = new TextBox();
            label2 = new Label();
            txtExplaination = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNo.Location = new Point(125, 12);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(191, 29);
            txtUserNo.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 15);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 8;
            label9.Text = "UserNo";
            // 
            // dpEnd
            // 
            dpEnd.Location = new Point(126, 82);
            dpEnd.Name = "dpEnd";
            dpEnd.Size = new Size(190, 29);
            dpEnd.TabIndex = 1;
            // 
            // dpStart
            // 
            dpStart.Location = new Point(126, 47);
            dpStart.Name = "dpStart";
            dpStart.Size = new Size(190, 29);
            dpStart.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 88);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 12;
            label7.Text = "End Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 53);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 10;
            label6.Text = "Start Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 120);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 8;
            label1.Text = "Day Amount";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDayAmount.Location = new Point(125, 117);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.ReadOnly = true;
            txtDayAmount.Size = new Size(191, 29);
            txtDayAmount.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 155);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 8;
            label2.Text = "Explaination";
            // 
            // txtExplaination
            // 
            txtExplaination.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtExplaination.Location = new Point(125, 152);
            txtExplaination.Multiline = true;
            txtExplaination.Name = "txtExplaination";
            txtExplaination.Size = new Size(348, 231);
            txtExplaination.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(303, 389);
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
            btnSave.Location = new Point(147, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmPermission
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 453);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dpEnd);
            Controls.Add(dpStart);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtExplaination);
            Controls.Add(label2);
            Controls.Add(txtDayAmount);
            Controls.Add(label1);
            Controls.Add(txtUserNo);
            Controls.Add(label9);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmPermission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserNo;
        private Label label9;
        private DateTimePicker dpEnd;
        private DateTimePicker dpStart;
        private Label label7;
        private Label label6;
        private Label label1;
        private TextBox txtDayAmount;
        private Label label2;
        private TextBox txtExplaination;
        private Button btnClose;
        private Button btnSave;
    }
}