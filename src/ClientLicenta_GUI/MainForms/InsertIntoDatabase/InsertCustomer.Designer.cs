namespace ClientLicenta_GUI.MainForms.InsertIntoDatabase
{
    partial class InsertCustomer
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
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.InstitutionTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstitutionTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name";
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.Location = new System.Drawing.Point(131, 26);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(383, 22);
            this.NameTextEdit.TabIndex = 1;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Location = new System.Drawing.Point(432, 253);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(82, 36);
            this.CancelSimpleButton.TabIndex = 2;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // SaveSimpleButton
            // 
            this.SaveSimpleButton.Location = new System.Drawing.Point(307, 253);
            this.SaveSimpleButton.Name = "SaveSimpleButton";
            this.SaveSimpleButton.Size = new System.Drawing.Size(82, 36);
            this.SaveSimpleButton.TabIndex = 3;
            this.SaveSimpleButton.Text = "Save";
            this.SaveSimpleButton.Click += new System.EventHandler(this.SaveSimpleButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 180);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Address";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 146);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Phone ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Mail";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 16);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Institution";
            // 
            // AddressTextEdit
            // 
            this.AddressTextEdit.Location = new System.Drawing.Point(131, 177);
            this.AddressTextEdit.Name = "AddressTextEdit";
            this.AddressTextEdit.Size = new System.Drawing.Size(383, 22);
            this.AddressTextEdit.TabIndex = 8;
            // 
            // PhoneTextEdit
            // 
            this.PhoneTextEdit.Location = new System.Drawing.Point(131, 140);
            this.PhoneTextEdit.Name = "PhoneTextEdit";
            this.PhoneTextEdit.Size = new System.Drawing.Size(383, 22);
            this.PhoneTextEdit.TabIndex = 9;
            this.PhoneTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // MailTextEdit
            // 
            this.MailTextEdit.Location = new System.Drawing.Point(131, 104);
            this.MailTextEdit.Name = "MailTextEdit";
            this.MailTextEdit.Size = new System.Drawing.Size(383, 22);
            this.MailTextEdit.TabIndex = 10;
            // 
            // InstitutionTextEdit
            // 
            this.InstitutionTextEdit.Location = new System.Drawing.Point(131, 66);
            this.InstitutionTextEdit.Name = "InstitutionTextEdit";
            this.InstitutionTextEdit.Size = new System.Drawing.Size(383, 22);
            this.InstitutionTextEdit.TabIndex = 11;
            // 
            // InsertCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 362);
            this.Controls.Add(this.InstitutionTextEdit);
            this.Controls.Add(this.MailTextEdit);
            this.Controls.Add(this.PhoneTextEdit);
            this.Controls.Add(this.AddressTextEdit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.SaveSimpleButton);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.NameTextEdit);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "InsertCustomer";
            this.Text = "Insert Customer";
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstitutionTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit AddressTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit MailTextEdit;
        private DevExpress.XtraEditors.TextEdit InstitutionTextEdit;
    }
}