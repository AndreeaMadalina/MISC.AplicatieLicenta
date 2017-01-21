namespace ClientLicenta_GUI.MainForms.InsertIntoDatabase
{
    partial class NewTaskForm
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
            this.textEditTitle = new DevExpress.XtraEditors.TextEdit();
            this.richTextBoxObservation = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonBack = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Title";
            // 
            // textEditTitle
            // 
            this.textEditTitle.Location = new System.Drawing.Point(101, 35);
            this.textEditTitle.Name = "textEditTitle";
            this.textEditTitle.Size = new System.Drawing.Size(349, 22);
            this.textEditTitle.TabIndex = 2;
            // 
            // richTextBoxObservation
            // 
            this.richTextBoxObservation.Location = new System.Drawing.Point(101, 77);
            this.richTextBoxObservation.Name = "richTextBoxObservation";
            this.richTextBoxObservation.Size = new System.Drawing.Size(349, 326);
            this.richTextBoxObservation.TabIndex = 3;
            this.richTextBoxObservation.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Observation";
            // 
            // simpleButtonBack
            // 
            this.simpleButtonBack.Location = new System.Drawing.Point(250, 427);
            this.simpleButtonBack.Name = "simpleButtonBack";
            this.simpleButtonBack.Size = new System.Drawing.Size(75, 37);
            this.simpleButtonBack.TabIndex = 5;
            this.simpleButtonBack.Text = "Back";
            this.simpleButtonBack.Click += new System.EventHandler(this.simpleButtonBack_Click);
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(375, 427);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(75, 37);
            this.simpleButtonAdd.TabIndex = 6;
            this.simpleButtonAdd.Text = "Add";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 501);
            this.Controls.Add(this.simpleButtonAdd);
            this.Controls.Add(this.simpleButtonBack);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.richTextBoxObservation);
            this.Controls.Add(this.textEditTitle);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "NewTaskForm";
            this.Text = "New Task";
            ((System.ComponentModel.ISupportInitialize)(this.textEditTitle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditTitle;
        private System.Windows.Forms.RichTextBox richTextBoxObservation;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBack;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
    }
}