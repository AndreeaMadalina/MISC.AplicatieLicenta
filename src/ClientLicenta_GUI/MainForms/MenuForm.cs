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
    public partial class MenuForm : Form
    {
        #region CONSTRUCTOR
        public MenuForm()
        {
            InitializeComponent();
            this.FormClosed += MainPage_FormClosed;
            UsernamelabelControl.Text = string.Format("WELCOME, {0} {1}!", 
                GlobalVariables.CurrentUser.Employee.FirstName,
                GlobalVariables.CurrentUser.Employee.LastName);
        }
        #endregion

        #region EVENTS
        #region MainPage_FormClosed
        void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        //Actionarea butonului de Logout care revine la pagina de Login
        #region LogoutButton_Click
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        #endregion

        //Inchiderea aplicatiei
        #region CloseButton_Click
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region EditDatabaseButton_Click
        private void EditDatabaseButton_Click(object sender, EventArgs e)
        {
            EditDatabaseForm editDB = new EditDatabaseForm();
            editDB.Show();
            editDB.FormClosed += form_FormClosed;
            this.Hide();
        }
        #endregion

        #region TasksButton_Click
        private void TasksButton_Click(object sender, EventArgs e)
        {
            TasksForm task = new TasksForm();
            task.Show();
            task.FormClosed += form_FormClosed;
            this.Hide();
        }
        #endregion

        #region ProjectStatusButton_Click
        private void ProjectStatusButton_Click(object sender, EventArgs e)
        {
            ProjectStatusForm project = new ProjectStatusForm();
            project.Show();
            project.FormClosed += form_FormClosed;
            this.Hide();
        }
        #endregion

        #region NewsFeedButton_Click
        private void NewsFeedButton_Click(object sender, EventArgs e)
        {
            NewsFeedForm news = new NewsFeedForm();
            news.Show();
            news.FormClosed += form_FormClosed;
            this.Hide();
        }
        #endregion

        #region NotesButton_Click
        private void NotesButton_Click(object sender, EventArgs e)
        {
            NotesForm notes = new NotesForm();
            notes.Show();
            notes.FormClosed += form_FormClosed;
            this.Hide();
        }
        #endregion

        #region HolidayButton_Click
        private void HolidayButton_Click(object sender, EventArgs e)
        {
            HolidayForm holiday = new HolidayForm();
            holiday.Show();
            holiday.FormClosed += form_FormClosed;
            this.Hide();
        }
        #endregion

        #region EmployeeListButton_Click
        private void EmployeeListButton_Click(object sender, EventArgs e)
        {
            EmployeesListForm employeeForm = new EmployeesListForm();
            employeeForm.Show();
            employeeForm.FormClosed += form_FormClosed;
            this.Hide();
        }
        #endregion

        #region form_FormClosed
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        #endregion
        #endregion

        //Functia verifica ce nivel de securitate are fiecare utilizator
        #region METHODS
        public void checkUser (int type)
        {
            if (type == 1)
            {               
                this.EditDatabaseButton.Visible = true;
                tableLayoutPanel5.SetColumn(EditDatabaseButton,0);
                tableLayoutPanel5.SetRow(EditDatabaseButton,4);
            }
            else if (type == 2)
            {
                this.EditDatabaseButton.Visible = false;
                this.ProjectStatusButton.Visible = true;
                this.EmployeeListButton.Visible = true;
            }
            else
            {
                this.EditDatabaseButton.Visible = false;
                this.EmployeeListButton.Visible = false;
                this.ProjectStatusButton.Visible = true;
            }
        }
        #endregion


    }
}
