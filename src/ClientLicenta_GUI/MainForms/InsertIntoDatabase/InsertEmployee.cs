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
    public partial class InsertEmployee : Form
    {
        #region VARIABLES
        private Service1Client _service = new Service1Client();
        private ReadServiceClient _serviceRead = new ReadServiceClient();
        private int priority;
        #endregion

        #region CONSTRUCTORS
        public InsertEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Clear();
            this.Load += InsertEmployee_Load;
        }
        #endregion

        #region EVENTS
        #region InsertEmployee_Load
        void InsertEmployee_Load(object sender, EventArgs e)
        {
            FillComboBoxDepartment();
            FillComboBoxJob();
            FillComboBoxSecurityLevel();
            DepartmentComboBox.SelectedIndex = -1;
            JobComboBox.SelectedIndex = -1;
            SecurityLevelComboBox.SelectedIndex = -1;
        }
        #endregion

        //Functia pentru a introduce doar cifre in textBox-urile PNCTextEdit,  SalaryTextEdit, FileNumberTextEdit
        #region textBox_KeyPress
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region CancelButton_Click
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SecurityLevelComboBox_SelectedIndexChanged
        private void SecurityLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priority = SecurityLevelComboBox.SelectedIndex + 1;
        }
        #endregion

        #region SaveButton_Click
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Se creaza o instanta de tipul EmployeeDTO
            EmployeeDTO employee = new EmployeeDTO();
            // Se creaza o instanta de tipul DepartmentDTO in care se vor pune datele departamentului unde va lucra noul angajat
            DepartmentDTO department = new DepartmentDTO();
            // Se creaza o instanta de tipul JobDTO in care se vor gasi datele job-ului angajatului
            JobDTO job = new JobDTO();
            // Se creaza o instanta de tipul LoginDTO care va reprezenta contul de acces al aplicatiei pentru noul angajat
            LoginDTO account = new LoginDTO();

            // Se adauga datele contului in instanta account si nivelul de securitate (cat de mult poate accesa aplicatia)
            account.Username = UsernameTextEdit.Text;
            account.Password = PasswordTextEdit.Text;
            account.SecurityLevel = priority;

            // Se adauga departamentul unde acesta va lucra
            employee.Department = department;
            // Se adauga job-ul pe care il va avea
            employee.Job = job;
            // Se adauga detalii personale despre angajat
            employee.FirstName = ucApplicantInsert1.GetFirstName;
            employee.LastName = ucApplicantInsert1.GetLastName;
            employee.BirthDate = CheckBirthDate(ucApplicantInsert1.GetBirthDate);
            employee.Mail = ucApplicantInsert1.GetMail;
            employee.Nationality = ucApplicantInsert1.GetNationality;
            employee.PhoneNumber = ucApplicantInsert1.GetPhone;
            employee.Studies = ucApplicantInsert1.GetStudies;
            employee.PNC = Convert.ToInt64(PNCTextEdit.Text);
            employee.Address = AddressTextEdit.Text;
            if (MaleCheckEdit.Checked)
            {
                employee.Gender = MaleCheckEdit.Text;
            }
            else
            {
                employee.Gender = FemaleCheckEdit.Text;
            }
            employee.Salary = Convert.ToInt32(SalaryTextEdit.Text);
            employee.Department = DepartmentComboBox.SelectedItem as DepartmentDTO;
            employee.Job = JobComboBox.SelectedItem as JobDTO;
            employee.FileNumber = Convert.ToInt32(FileNumberTextEdit.Text);

            // Se verifica daca inregistrarea a avut loc cu succes sau nu si se afiseaza un mesaj in functie de caz
            if (_service.InsertEmployee(employee, account))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please try again!");
            }
            // Se inchide forma de inserare angajat
            this.Close();
        }
        #endregion
        #endregion

        #region METHODS
        //Popularea comboBox-urilor cu valori
        #region FillComboBoxSecurityLevel
        private void FillComboBoxSecurityLevel()
        {
            SecurityLevel security = new SecurityLevel();
            SecurityLevelComboBox.DataSource = new BindingSource(security.Dictionary, null);
            SecurityLevelComboBox.DisplayMember = "Key";
            bla.Text = (SecurityLevelComboBox.SelectedIndex + 1).ToString();
        }
        #endregion

        #region FillComboBoxDepartment
        private void FillComboBoxDepartment()
        {
            DepartmentComboBox.DataSource = _serviceRead.FillComboBoxDepartment();
            DepartmentComboBox.DisplayMember = "DepartmentName";
        }
        #endregion

        #region FillComboBoxJob
        private void FillComboBoxJob()
        {
            JobComboBox.DataSource = _serviceRead.FillComboBoxJob();
            JobComboBox.DisplayMember = "JobTitle";
        }
        #endregion

        //Verifica daca este corect introdusa data.
        #region CheckBirthDate
        private DateTime CheckBirthDate(string date)
        {
            DateTime dateBirth = default(DateTime);
            if (DateTime.TryParse(date, out dateBirth))
            {
                dateBirth = Convert.ToDateTime(date);
            }
            else
            {
                MessageBox.Show("Invalid date!");
            }
            return dateBirth;
        }
        #endregion

        #region Clear
        private void Clear()
        {
            DepartmentComboBox.DataSource = null;
            JobComboBox.DataSource = null;
        }
        #endregion
        #endregion


    }
}
