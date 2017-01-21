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
    public partial class AllHolidaysForm : Form
    {
        #region VARIABLES
        private Service1Client _service = new Service1Client();
        #endregion
        public AllHolidaysForm()
        {
            InitializeComponent();
            HolidaysGridView.Columns.Clear();
            HolidaysGridControl.DataSource = null;
        }

        private void AllHolidaysForm_Load(object sender, EventArgs e)
        {
            HolidaysGridView.Columns.Clear();
            HolidaysGridControl.DataSource = null;
            HolidaysGridControl.DataSource = _service.FillHolidaysGrid().Select(x => new
            {
                ID = x.HolidayID,
                Employee = string.Format("{0} {1}", x.Employee.FirstName, x.Employee.LastName),
                Holiday = string.Format("{0} - {1}", x.StartDate.ToString("dd/MM/yyyy"), x.EndDate.ToString("dd/MM/yyyy")),
                Type = (x.Type != null) ? x.Type : "-",
            }).ToList();

            HolidaysGridView.BestFitColumns(true);
        }
    }
}
