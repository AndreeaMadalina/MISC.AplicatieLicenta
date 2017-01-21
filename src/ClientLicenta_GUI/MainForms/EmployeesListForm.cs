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
    public partial class EmployeesListForm : Form
    {
        private Service1Client _service = new Service1Client();
        public EmployeesListForm()
        {
            InitializeComponent();
            gridViewEmployees.Columns.Clear();
            gridControlEmployees.DataSource = null;
            GlobalVariables.CurrentEmployeeID = 0;
        }

        private void EmployeesListForm_Load(object sender, EventArgs e)
        {
            gridViewEmployees.Columns.Clear();
            gridControlEmployees.DataSource = null;
            gridControlEmployees.DataSource = _service.FillProjectEmployeesGrid(GlobalVariables.CurrentUser.EmployeeID).Select(x => new
            {
                Employee = string.Format("{0} {1}", x.FirstName, x.LastName),
                Mail = x.Mail,
                Phone = x.PhoneNumber,
                ID = x.EmployeeID
            }).ToList();

            //gridControlEmployees.DataSource = _service.FillProjectEmployeesGrid(GlobalVariables.CurrentUser.EmployeeID);
            gridViewEmployees.BestFitColumns(true);
            GridLayout();
        }

        private void gridViewEmployees_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            for (int i = 0; i < gridViewEmployees.RowCount; i++)
            {
                if (e.Clicks == 2)
                {
                    int row = (gridViewEmployees.GetSelectedRows()[i]);
                    EmployeeDTO employee = gridViewEmployees.GetRow(row) as EmployeeDTO;
                    if (employee == null)
                    {
                        return;
                    }
                    else
                    {
                        GlobalVariables.CurrentEmployeeID = employee.EmployeeID;
                    }
                    NewTaskForm task = new NewTaskForm();
                    task.Show();
                }
            }
            
        }

        private void simpleButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewEmployees_DoubleClick(object sender, EventArgs e)
        {
            //GlobalVariables.CurrentEmployeeID = (e as EmployeeDTO).EmployeeID;
        }

        private void GridLayout()
        {
            //gridViewEmployees.Columns["Employee"].OptionsColumn.AllowEdit = false;
            //gridViewEmployees.Columns["Employee"].OptionsColumn.AllowFocus = false;
            //gridViewEmployees.Columns["Mail"].OptionsColumn.AllowEdit = false;
            //gridViewEmployees.Columns["Mail"].OptionsColumn.AllowFocus = false;
            //gridViewEmployees.Columns["Phone"].OptionsColumn.AllowEdit = false;
            //gridViewEmployees.Columns["Phone"].OptionsColumn.AllowFocus = false;
            gridViewEmployees.OptionsBehavior.Editable = false;
        }
    }
}
