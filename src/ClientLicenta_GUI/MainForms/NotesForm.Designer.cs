namespace ClientLicenta_GUI
{
    partial class NotesForm
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
            this.AddNoteButton = new DevExpress.XtraEditors.SimpleButton();
            this.DateListBox = new System.Windows.Forms.ListBox();
            this.BackButton = new DevExpress.XtraEditors.SimpleButton();
            this.NotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Location = new System.Drawing.Point(413, 51);
            this.AddNoteButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(100, 28);
            this.AddNoteButton.TabIndex = 7;
            this.AddNoteButton.Text = "Add Note";
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // DateListBox
            // 
            this.DateListBox.FormattingEnabled = true;
            this.DateListBox.ItemHeight = 16;
            this.DateListBox.Location = new System.Drawing.Point(46, 96);
            this.DateListBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateListBox.Name = "DateListBox";
            this.DateListBox.Size = new System.Drawing.Size(159, 404);
            this.DateListBox.TabIndex = 5;
            this.DateListBox.SelectedIndexChanged += new System.EventHandler(this.DateListBox_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(799, 509);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 28);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NotesRichTextBox
            // 
            this.NotesRichTextBox.Location = new System.Drawing.Point(212, 96);
            this.NotesRichTextBox.Name = "NotesRichTextBox";
            this.NotesRichTextBox.Size = new System.Drawing.Size(687, 406);
            this.NotesRichTextBox.TabIndex = 8;
            this.NotesRichTextBox.Text = "";
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 588);
            this.Controls.Add(this.NotesRichTextBox);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.DateListBox);
            this.Controls.Add(this.BackButton);
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton AddNoteButton;
        private System.Windows.Forms.ListBox DateListBox;
        private DevExpress.XtraEditors.SimpleButton BackButton;
        private System.Windows.Forms.RichTextBox NotesRichTextBox;
    }
}