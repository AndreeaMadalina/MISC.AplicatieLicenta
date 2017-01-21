namespace ClientLicenta_GUI.MainForms.InsertIntoDatabase
{
    partial class InsertEmployee
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PNCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FileNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.MaleCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.FemaleCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.ucApplicantInsert1 = new ClientLicenta_GUI.UserControls.ucApplicantInsert();
            this.UsernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.SecurityLevelComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.PasswordTextEdit = new System.Windows.Forms.TextBox();
            this.bla = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PNCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaleCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FemaleCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(365, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "PNC";
            // 
            // PNCTextEdit
            // 
            this.PNCTextEdit.Location = new System.Drawing.Point(474, 15);
            this.PNCTextEdit.Name = "PNCTextEdit";
            this.PNCTextEdit.Size = new System.Drawing.Size(220, 22);
            this.PNCTextEdit.TabIndex = 2;
            this.PNCTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // SalaryTextEdit
            // 
            this.SalaryTextEdit.Location = new System.Drawing.Point(474, 134);
            this.SalaryTextEdit.Name = "SalaryTextEdit";
            this.SalaryTextEdit.Size = new System.Drawing.Size(220, 22);
            this.SalaryTextEdit.TabIndex = 4;
            this.SalaryTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // FileNumberTextEdit
            // 
            this.FileNumberTextEdit.Location = new System.Drawing.Point(474, 257);
            this.FileNumberTextEdit.Name = "FileNumberTextEdit";
            this.FileNumberTextEdit.Size = new System.Drawing.Size(220, 22);
            this.FileNumberTextEdit.TabIndex = 5;
            this.FileNumberTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(365, 179);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Department";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(365, 140);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Salary";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(365, 263);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "File Number";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(365, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Gender";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(365, 217);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(19, 16);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Job";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(474, 497);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 38);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(619, 497);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 38);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddressTextEdit
            // 
            this.AddressTextEdit.Location = new System.Drawing.Point(474, 54);
            this.AddressTextEdit.Name = "AddressTextEdit";
            this.AddressTextEdit.Size = new System.Drawing.Size(220, 22);
            this.AddressTextEdit.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(365, 60);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 16);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Address";
            // 
            // MaleCheckEdit
            // 
            this.MaleCheckEdit.Location = new System.Drawing.Point(474, 99);
            this.MaleCheckEdit.Name = "MaleCheckEdit";
            this.MaleCheckEdit.Properties.Caption = "Male";
            this.MaleCheckEdit.Size = new System.Drawing.Size(75, 20);
            this.MaleCheckEdit.TabIndex = 19;
            // 
            // FemaleCheckEdit
            // 
            this.FemaleCheckEdit.Location = new System.Drawing.Point(619, 99);
            this.FemaleCheckEdit.Name = "FemaleCheckEdit";
            this.FemaleCheckEdit.Properties.Caption = "Female";
            this.FemaleCheckEdit.Size = new System.Drawing.Size(75, 20);
            this.FemaleCheckEdit.TabIndex = 20;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(474, 171);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(220, 24);
            this.DepartmentComboBox.TabIndex = 21;
            // 
            // JobComboBox
            // 
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Location = new System.Drawing.Point(474, 209);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(220, 24);
            this.JobComboBox.TabIndex = 22;
            // 
            // ucApplicantInsert1
            // 
            this.ucApplicantInsert1.Location = new System.Drawing.Point(12, 12);
            this.ucApplicantInsert1.Name = "ucApplicantInsert1";
            this.ucApplicantInsert1.Size = new System.Drawing.Size(314, 267);
            this.ucApplicantInsert1.TabIndex = 0;
            // 
            // UsernameTextEdit
            // 
            this.UsernameTextEdit.Location = new System.Drawing.Point(106, 372);
            this.UsernameTextEdit.Name = "UsernameTextEdit";
            this.UsernameTextEdit.Size = new System.Drawing.Size(220, 22);
            this.UsernameTextEdit.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 430);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 16);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Password";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 378);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 16);
            this.labelControl9.TabIndex = 26;
            this.labelControl9.Text = "Username";
            // 
            // SecurityLevelComboBox
            // 
            this.SecurityLevelComboBox.FormattingEnabled = true;
            this.SecurityLevelComboBox.Location = new System.Drawing.Point(106, 472);
            this.SecurityLevelComboBox.Name = "SecurityLevelComboBox";
            this.SecurityLevelComboBox.Size = new System.Drawing.Size(220, 24);
            this.SecurityLevelComboBox.TabIndex = 27;
            this.SecurityLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.SecurityLevelComboBox_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 480);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(79, 16);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "Security Level";
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.Location = new System.Drawing.Point(106, 424);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.PasswordChar = '*';
            this.PasswordTextEdit.Size = new System.Drawing.Size(220, 22);
            this.PasswordTextEdit.TabIndex = 29;
            // 
            // bla
            // 
            this.bla.Location = new System.Drawing.Point(499, 375);
            this.bla.Name = "bla";
            this.bla.Size = new System.Drawing.Size(31, 16);
            this.bla.TabIndex = 30;
            this.bla.Text = "eqwe";
            // 
            // InsertEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 597);
            this.Controls.Add(this.bla);
            this.Controls.Add(this.PasswordTextEdit);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.SecurityLevelComboBox);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.UsernameTextEdit);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.FemaleCheckEdit);
            this.Controls.Add(this.MaleCheckEdit);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.AddressTextEdit);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.FileNumberTextEdit);
            this.Controls.Add(this.SalaryTextEdit);
            this.Controls.Add(this.PNCTextEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ucApplicantInsert1);
            this.MaximizeBox = false;
            this.Name = "InsertEmployee";
            this.Text = "Insert Employee";
            ((System.ComponentModel.ISupportInitialize)(this.PNCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaleCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FemaleCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ucApplicantInsert ucApplicantInsert1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit PNCTextEdit;
        private DevExpress.XtraEditors.TextEdit SalaryTextEdit;
        private DevExpress.XtraEditors.TextEdit FileNumberTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.TextEdit AddressTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit MaleCheckEdit;
        private DevExpress.XtraEditors.CheckEdit FemaleCheckEdit;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ComboBox JobComboBox;
        private DevExpress.XtraEditors.TextEdit UsernameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox SecurityLevelComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox PasswordTextEdit;
        private DevExpress.XtraEditors.LabelControl bla;
    }
}