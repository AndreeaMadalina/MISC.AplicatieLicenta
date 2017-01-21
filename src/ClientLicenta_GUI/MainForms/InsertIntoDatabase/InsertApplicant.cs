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

namespace ClientLicenta_GUI.MainForms
{
    public partial class InsertApplicant : Form
    {
        private Service1Client _service = new Service1Client();
        public InsertApplicant()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Clear();
        }

        void InsertApplicant_Load(object sender, EventArgs e)
        {
            FillComboBoxDepartment();
            FillComboBoxJob();
            DepartmentComboBox.SelectedIndex = -1;
            JobComboBox.SelectedIndex = -1;
        }

        private void Clear()
        {
            DepartmentComboBox.DataSource = null;
            JobComboBox.DataSource = null;
        }

        //Popularea comboBox-urilor cu valori
        #region ComboBox
        private void FillComboBoxDepartment()
        {
            DepartmentComboBox.DataSource = _service.FillComboBoxDepartment();
            DepartmentComboBox.DisplayMember = "DepartmentName";
        }
        private void FillComboBoxJob()
        {
            JobComboBox.DataSource = _service.FillComboBoxJob();
            JobComboBox.DisplayMember = "JobTitle";
        }
        #endregion

        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            ApplicantDTO applicant = new ApplicantDTO();
            applicant.FirstName = ucApplicantInsert1.GetFirstName;
            applicant.LastName = ucApplicantInsert1.GetLastName;
            string observation = null;
            string job = null;
            string department = null;
            applicant.BirthDate = CheckBirthDate(ucApplicantInsert1.GetBirthDate);
            applicant.Mail = ucApplicantInsert1.GetMail;
            applicant.Nationality = ucApplicantInsert1.GetNationality;
            applicant.PhoneNumber = ucApplicantInsert1.GetPhone;
            applicant.Studies = ucApplicantInsert1.GetStudies;

            if(InternshipCheckBox.Checked)
            {
                observation = InternshipCheckBox.Text;
            }
            else
            {
                job = (JobComboBox.SelectedItem as JobDTO).JobTitle;
                department = (DepartmentComboBox.SelectedItem as DepartmentDTO).DepartmentName;
            }
            

            if (_service.InsertApplicant(applicant, job, department, observation))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please try again!");
            }
            this.Close();
        }

        //Verifica daca este corect introdusa data.
        #region Check if date format is correct
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

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InternshipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DepartmentComboBox.Enabled = false;
            JobComboBox.Enabled = false;
            Clear();
        }
    }
}
