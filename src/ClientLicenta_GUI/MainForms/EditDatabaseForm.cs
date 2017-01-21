using ClientLicenta_GUI.MainForms;
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
    public partial class EditDatabaseForm : Form
    {
        private Service1Client _service = new Service1Client();
        public EditDatabaseForm()
        {
            InitializeComponent();
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.DataSource = _service.FillApplicantGrid().Select(x => new
            {
                ID = x.ApplicantID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Studies = x.Studies,
                PhoneNumber = x.PhoneNumber,
                Mail = x.Mail
            }).ToList();

            gridView1.BestFitColumns(true);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.DataSource = _service.FillEmployeeGrid().Select(x => new
            {
                ID = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Mail = x.Mail,
                Phone = x.PhoneNumber,
                Address = x.Address,
                Studies = x.Studies,
                BirthDate = x.BirthDate,
                HireDate = x.HireDate,
                Nationality = x.Nationality,
                Gender = x.Gender,
                Salary = x.Salary,
                FileNumber = x.FileNumber,
                Department = x.Department.DepartmentName,
                Location = x.Department.Location,
                Job = x.Job.JobTitle
            }).ToList();

            gridView1.BestFitColumns(true);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.DataSource = _service.FillCustomerGrid().Select(x => new
            {
                ID = x.CustomerID,
                CustomerName = x.Name,
                Address = x.Address,
                Mail = x.Mail,
                Phone = x.PhoneNumber,
                Institution = x.Institution
            }).ToList();

            gridView1.BestFitColumns(true);
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.DataSource = _service.FillProjectGrid().Select(x => new
            {
                ID = x.ProjectID,
                ProjectName = x.ProjectName,
                Customer = x.Customer.Name,
                Employee = string.Format("{0} {1}", x.Employee.FirstName, x.Employee.LastName),
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Status = x.Status,
                Price = x.Price,
                Description = x.Description
            }).ToList();

            gridView1.BestFitColumns(true);
        }

        private void internsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.DataSource = _service.FillInternGrid().Select(x => new
            {
                ID = x.InternID,
                Name = string.Format("{0} {1}", x.Applicant.FirstName, x.Applicant.LastName),
                Supervisor = string.Format("{0} {1}", x.Employee.FirstName, x.Employee.LastName),
                Mail = x.Applicant.Mail,
                Phone = x.Applicant.PhoneNumber,
                Studies = x.Applicant.Studies,
                Nationality = x.Applicant.Nationality,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Observation = x.Observation
            }).ToList();

            gridView1.BestFitColumns(true);
        }

        private void applicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertApplicant insert = new InsertApplicant();
            insert.Text = "Insert a new Applicant";
            insert.Show();
            insert.FormClosed += insert_FormClosed;
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertEmployee insert = new InsertEmployee();
            insert.Text = "Insert a new Employee";
            insert.Show();
            insert.FormClosed += insert_FormClosed;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertCustomer insert = new InsertCustomer();
            insert.Text = "Insert a new Customer";
            insert.Show();
            insert.FormClosed += insert_FormClosed;
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertProject insert = new InsertProject();
            insert.Text = "Insert a new Project";
            insert.Show();
            insert.FormClosed += insert_FormClosed;
        }

        private void internToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertIntern insert = new InsertIntern();
            insert.Text = "Insert a new Intern";
            insert.Show();
            insert.FormClosed += insert_FormClosed;
        }

        void insert_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
