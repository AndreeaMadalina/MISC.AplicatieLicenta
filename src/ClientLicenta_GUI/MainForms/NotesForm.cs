using ClientLicenta_GUI.MainForms.InsertIntoDatabase;
using ClientLicenta_GUI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLicenta_GUI
{
    public partial class NotesForm : Form
    {
        #region VARIABLES
        private Service1Client _service = new Service1Client();
        #endregion

        #region CONTRUCTORS
        public NotesForm()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS
        #region BackButton_Click
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region AddNoteButton_Click
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            InsertNotes note = new InsertNotes();
            note.Show();
            note.FormClosed += note_FormClosed;
            this.Hide();
        }
        #endregion

        #region note_FormClosed
        void note_FormClosed(object sender, FormClosedEventArgs e)
        {
            NotesForm_Load(sender, e);
            this.Show();
        }
        #endregion
        

        #region NotesForm_Load
        private void NotesForm_Load(object sender, EventArgs e)
        {
            DateListBox.DataSource = _service.FillNoteListBox(GlobalVariables.CurrentUser.LoginID);
            DateListBox.DisplayMember = "Date";
        }
        #endregion

        #region DateListBox_SelectedIndexChanged
        private void DateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var note = DateListBox.SelectedItem as NoteDTO;
            if(DateListBox.SelectedIndex >= 0)
            {
                NotesRichTextBox.Text = note.Description;
            }
        }
        #endregion
        #endregion
    }
}
