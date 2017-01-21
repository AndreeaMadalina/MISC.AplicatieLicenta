using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLicenta_GUI.UserControls
{
    public partial class ucApplicantInsert : UserControl
    {
        public ucApplicantInsert()
        {
            InitializeComponent();
        }

    #region Properties
        public string GetFirstName
        {
            get { return FirstNameTextEdit.Text; }
        }
        public string GetLastName
        {
            get { return LastNameTextEdit.Text; }
        }
        public string GetStudies
        {
            get { return StudiesTextEdit.Text; }
        }
        public string GetPhone
        {
            get { return PhoneTextEdit.Text; }
        }
        public string GetMail
        {
            get { return MailTextEdit.Text; }
        }
        public string GetBirthDate
        {
            get { return BirthDateTextEdit.Text; }
        }
        public string GetNationality
        {
            get { return NationalityTextEdit.Text; }
        }
    #endregion

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
