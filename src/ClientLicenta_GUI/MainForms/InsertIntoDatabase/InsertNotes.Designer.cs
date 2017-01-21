namespace ClientLicenta_GUI.MainForms.InsertIntoDatabase
{
    partial class InsertNotes
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
            this.NotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // NotesRichTextBox
            // 
            this.NotesRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.NotesRichTextBox.Name = "NotesRichTextBox";
            this.NotesRichTextBox.Size = new System.Drawing.Size(704, 333);
            this.NotesRichTextBox.TabIndex = 0;
            this.NotesRichTextBox.Text = "";
            // 
            // SaveSimpleButton
            // 
            this.SaveSimpleButton.Location = new System.Drawing.Point(598, 369);
            this.SaveSimpleButton.Name = "SaveSimpleButton";
            this.SaveSimpleButton.Size = new System.Drawing.Size(88, 41);
            this.SaveSimpleButton.TabIndex = 1;
            this.SaveSimpleButton.Text = "Save";
            this.SaveSimpleButton.Click += new System.EventHandler(this.SaveSimpleButton_Click);
            // 
            // InsertNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 422);
            this.Controls.Add(this.SaveSimpleButton);
            this.Controls.Add(this.NotesRichTextBox);
            this.Name = "InsertNotes";
            this.Text = "InsertNotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotesRichTextBox;
        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton;
    }
}