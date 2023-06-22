namespace PersonalTracking
{
    partial class frmPosition
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
            label1 = new Label();
            txtPosition = new TextBox();
            label2 = new Label();
            cmbDepartment = new ComboBox();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Position";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPosition.Location = new Point(175, 29);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(150, 29);
            txtPosition.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 88);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 0;
            label2.Text = "Department";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(175, 87);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(150, 29);
            cmbDepartment.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(175, 151);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 50);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(19, 151);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmPosition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 217);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(cmbDepartment);
            Controls.Add(label2);
            Controls.Add(txtPosition);
            Controls.Add(label1);
            Name = "frmPosition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Position";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPosition;
        private Label label2;
        private ComboBox cmbDepartment;
        private Button btnClose;
        private Button btnSave;
    }
}