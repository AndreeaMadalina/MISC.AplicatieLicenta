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
    public partial class HolidayForm : Form
    {
        #region VARIABLES
        private Service1Client _service = new Service1Client();
        #endregion

        #region CONSTRUCTORS
        public HolidayForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        #region EVENTS
        #region BackButton_Click
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SubmitButton_Click
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            HolidayDTO holiday = new HolidayDTO();
            holiday.EmployeeID = GlobalVariables.CurrentUser.EmployeeID;
            holiday.StartDate = StartDateEdit.DateTime;
            holiday.EndDate = EndDateEdit.DateTime;

            if(_service.InsertHoliday(holiday))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        #endregion

        #region SeeHollidaysSimpleButton_Click
        private void SeeHollidaysSimpleButton_Click(object sender, EventArgs e)
        {
            AllHolidaysForm holidays = new AllHolidaysForm();
            holidays.Show();
            this.Hide();
            holidays.FormClosed += holidays_FormClosed;
        }
        #endregion

        #region holidays_FormClosed
        void holidays_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        #endregion
        #endregion
    }
}