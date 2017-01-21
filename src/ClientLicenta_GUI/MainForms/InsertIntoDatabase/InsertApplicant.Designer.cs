namespace ClientLicenta_GUI.MainForms
{
    partial class InsertApplicant
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
            this.SaveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.InternshipCheckBox = new System.Windows.Forms.CheckBox();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.ucApplicantInsert1 = new ClientLicenta_GUI.UserControls.ucApplicantInsert();
            this.SuspendLayout();
            // 
            // SaveSimpleButton
            // 
            this.SaveSimpleButton.Location = new System.Drawing.Point(500, 24);
            this.SaveSimpleButton.Name = "SaveSimpleButton";
            this.SaveSimpleButton.Size = new System.Drawing.Size(86, 33);
            this.SaveSimpleButton.TabIndex = 1;
            this.SaveSimpleButton.Text = "Save";
            this.SaveSimpleButton.Click += new System.EventHandler(this.SaveSimpleButton_Click);
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Location = new System.Drawing.Point(500, 119);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(86, 33);
            this.CancelSimpleButton.TabIndex = 2;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 301);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Job";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 346);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Department";
            // 
            // InternshipCheckBox
            // 
            this.InternshipCheckBox.AutoSize = true;
            this.InternshipCheckBox.Location = new System.Drawing.Point(103, 386);
            this.InternshipCheckBox.Name = "InternshipCheckBox";
            this.InternshipCheckBox.Size = new System.Drawing.Size(92, 21);
            this.InternshipCheckBox.TabIndex = 8;
            this.InternshipCheckBox.Text = "Internship";
            this.InternshipCheckBox.UseVisualStyleBackColor = true;
            this.InternshipCheckBox.CheckedChanged += new System.EventHandler(this.InternshipCheckBox_CheckedChanged);
            // 
            // JobComboBox
            // 
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Location = new System.Drawing.Point(103, 331);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(220, 24);
            this.JobComboBox.TabIndex = 24;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(103, 293);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(220, 24);
            this.DepartmentComboBox.TabIndex = 23;
            // 
            // ucApplicantInsert1
            // 
            this.ucApplicantInsert1.Location = new System.Drawing.Point(12, 12);
            this.ucApplicantInsert1.Name = "ucApplicantInsert1";
            this.ucApplicantInsert1.Size = new System.Drawing.Size(312, 283);
            this.ucApplicantInsert1.TabIndex = 3;
            // 
            // InsertApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 419);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.InternshipCheckBox);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ucApplicantInsert1);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.SaveSimpleButton);
            this.MaximizeBox = false;
            this.Name = "InsertApplicant";
            this.Text = "Insert Applicant";
            this.Load += new System.EventHandler(this.InsertApplicant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private UserControls.ucApplicantInsert ucApplicantInsert1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.CheckBox InternshipCheckBox;
        private System.Windows.Forms.ComboBox JobComboBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
    }
}