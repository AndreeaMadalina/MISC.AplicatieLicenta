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

namespace ClientLicenta_GUI.MainForms.InsertIntoDatabase
{
    public partial class InsertNotes : Form
    {
        #region VARIABLES
        private Service1Client _service = new Service1Client();
        #endregion

        #region CONSTRUCTORS
        public InsertNotes()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS
        #region SaveSimpleButton_Click
        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            NoteDTO note = new NoteDTO();
            note.Date = DateTime.Now;
            note.Description = NotesRichTextBox.Text;
            note.UserID = GlobalVariables.CurrentUser.LoginID;
            if(_service.InsertNotes(note))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            this.Close();
        }
        #endregion
        #endregion
    }
}
