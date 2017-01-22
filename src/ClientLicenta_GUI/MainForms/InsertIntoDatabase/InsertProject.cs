using ClientLicenta_GUI.ServiceReference1;
using Model;
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
    public partial class InsertProject : Form
    {
        #region Variables
        private Service1Client _service = new Service1Client();
        private ReadServiceClient _serviceRead = new ReadServiceClient();
        Employee _employee;
        private int _customerID;
        private int _employeeID;
        #endregion

        #region Constructors
        public InsertProject()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CustomerComboBox.SelectedIndex = -1;
            TechnologyComboBox.SelectedIndex = -1;
        }
        #endregion

        #region Events
        #region InsertProject_Load
        void InsertProject_Load(object sender, EventArgs e)
        {
            Clear();
            FillComboBoxCustomer();
            FillComboBoxTechnology();
            CustomerComboBox.SelectedIndex = -1;
            TechnologyComboBox.SelectedIndex = -1;
            //ProjectManagerComboBox.SelectedIndex = -1;            
        }
        #endregion

        //In functie de tehnologia selectata, ProjectManagerComboBox v-a fi populat doar cu managerii de proiect 
        //care lucreaza in departamentul asociat tehnologieirespective (numele tehnologiei este acelasi cu cel al departamentului)
        #region TechnologyComboBox_SelectedIndexChanged
        private void TechnologyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TechnologyComboBox.SelectedIndex >= 0)
            {
                ProjectManagerComboBox.Items.Clear();
                int departmentID = (TechnologyComboBox.SelectedItem as DepartmentDTO).DepartmentID;
                FillComboBoxProjectManager(departmentID);
            }
            else
            {
                ProjectManagerComboBox.SelectedIndex = -1;
            }
        }
        #endregion

        #region ProjectManagerComboBox_SelectedIndexChanged
        private void ProjectManagerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectManagerComboBox.SelectedIndex >= 0)
            {
                _employeeID = (ProjectManagerComboBox.SelectedItem as Employee).ID;
            }
        }
        #endregion

        #region CustomerComboBox_SelectedIndexChanged
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex >= 0)
            {
                _customerID = (CustomerComboBox.SelectedItem as CustomerDTO).CustomerID;
            }
            else return;
        }
        #endregion

        #region CancelSimpleButton_Click
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SaveSimpleButton_Click
        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            
            ProjectDTO project = new ProjectDTO();
            project.CustomerID = _customerID;
            project.EmployeeID = _employeeID;
            project.StartDate = CheckStartDate(StartDateTextEdit.Text);
            project.EndDate = CheckEndDate(EndDateTextEdit.Text);
            project.Price = Convert.ToInt32(PriceTextEdit.Text);
            project.ProjectName = ProjectNameTextEdit.Text;
            project.Technology = TechnologyComboBox.Text;

            if(_service.InsertProject(project))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        #endregion
        #endregion

        #region Methods
        //Curatare comboBox-uri
        #region Clear
        private void Clear()
        {
            CustomerComboBox.DataSource = null;
            ProjectManagerComboBox.DataSource = null;
            TechnologyComboBox.DataSource = null;
        }
        #endregion

        //Popularea comboBox-urilor cu valori
        #region FillComboBoxCustomer
        private void FillComboBoxCustomer()
        {
            CustomerComboBox.DataSource = _serviceRead.FillComboBoxCustomer();
            CustomerComboBox.DisplayMember = "Name";
            //List<CustomerDTO> customerList = new List<CustomerDTO>();
            //foreach (var item in collection)
            //{
                
            //}
        }
        #endregion

        #region FillComboBoxTechnology
        private void FillComboBoxTechnology()
        {
            TechnologyComboBox.DataSource = _serviceRead.FillComboBoxDepartment();
            TechnologyComboBox.DisplayMember = "DepartmentName";
        }
        #endregion

        #region FillComboBoxProjectManager
        private void FillComboBoxProjectManager(int departmentID)
        {
            List<Employee> employeeList = new List<Employee>();
            
            foreach (EmployeeDTO item in _serviceRead.FillComboBoxProjectManager(departmentID))
            {
                EmployeeDTO employeeDTO = new EmployeeDTO();
                employeeDTO = item;
                _employee = new Employee(employeeDTO.FirstName, employeeDTO.LastName, employeeDTO.EmployeeID);

                employeeList.Add(_employee);
                ProjectManagerComboBox.Items.Add(_employee);
                ProjectManagerComboBox.DisplayMember = "Name";
            }

            //ProjectManagerComboBox.DataSource = employeeList;
            //ProjectManagerComboBox.DisplayMember = "Name";
        }
        #endregion

        //Verifica daca este corect introdusa data.
        #region Check if date format is correct
        private DateTime CheckStartDate(string date)
        {
            DateTime dateStart = default(DateTime);
            if (DateTime.TryParse(date, out dateStart))
            {
                dateStart = Convert.ToDateTime(date);
            }
            else
            {
                MessageBox.Show("Invalid date!");
            }
            return dateStart;
        }
        private DateTime CheckEndDate(string date)
        {
            DateTime dateEnd = default(DateTime);
            if (DateTime.TryParse(date, out dateEnd))
            {
                dateEnd = Convert.ToDateTime(date);
            }
            else
            {
                MessageBox.Show("Invalid date!");
            }
            return dateEnd;
        }
        #endregion

        //Functia pentru a introduce doar cifre in textBox-urile PNCTextEdit,  SalaryTextEdit, FileNumberTextEdit
        #region Only numbers can be inserted
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion
        #endregion 

    }
}