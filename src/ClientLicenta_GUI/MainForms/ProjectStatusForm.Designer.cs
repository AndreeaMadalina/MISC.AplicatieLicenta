namespace ClientLicenta_GUI
{
    partial class ProjectStatusForm
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
            this.UpdateStatusTextBox = new DevExpress.XtraEditors.TextEdit();
            this.StatusBox = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.UpdateStatusButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BackButton = new DevExpress.XtraEditors.SimpleButton();
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateStatusTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateStatusTextBox
            // 
            this.UpdateStatusTextBox.Location = new System.Drawing.Point(310, 371);
            this.UpdateStatusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateStatusTextBox.Name = "UpdateStatusTextBox";
            this.UpdateStatusTextBox.Size = new System.Drawing.Size(113, 22);
            this.UpdateStatusTextBox.TabIndex = 13;
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(429, 164);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(4);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(132, 36);
            this.StatusBox.TabIndex = 12;
            this.StatusBox.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl2.Location = new System.Drawing.Point(432, 132);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 24);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Status";
            // 
            // UpdateStatusButton
            // 
            this.UpdateStatusButton.Location = new System.Drawing.Point(310, 319);
            this.UpdateStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateStatusButton.Name = "UpdateStatusButton";
            this.UpdateStatusButton.Size = new System.Drawing.Size(113, 28);
            this.UpdateStatusButton.TabIndex = 10;
            this.UpdateStatusButton.Text = "Update Status";
            this.UpdateStatusButton.Click += new System.EventHandler(this.UpdateStatusButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(199, 29);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Project Description";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(676, 367);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 28);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.FormattingEnabled = true;
            this.DescriptionListBox.ItemHeight = 16;
            this.DescriptionListBox.Location = new System.Drawing.Point(13, 50);
            this.DescriptionListBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.Size = new System.Drawing.Size(408, 260);
            this.DescriptionListBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Project Name";
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(429, 50);
            this.ProjectComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(160, 24);
            this.ProjectComboBox.TabIndex = 17;
            this.ProjectComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectComboBox_SelectedIndexChanged);
            // 
            // ProjectStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectComboBox);
            this.Controls.Add(this.DescriptionListBox);
            this.Controls.Add(this.UpdateStatusTextBox);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.UpdateStatusButton);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BackButton);
            this.Name = "ProjectStatusForm";
            this.Text = "ProjectStatusForm";
            this.Load += new System.EventHandler(this.ProjectStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateStatusTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UpdateStatusTextBox;
        private System.Windows.Forms.RichTextBox StatusBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton UpdateStatusButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BackButton;
        private System.Windows.Forms.ListBox DescriptionListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProjectComboBox;
    }
}