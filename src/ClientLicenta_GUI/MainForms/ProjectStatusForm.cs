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
    public partial class ProjectStatusForm : Form
    {
        #region VARIABLES
        private Service1Client _service = new Service1Client();
        private List<ProjectDTO> _projectList = new List<ProjectDTO>();
        private int _projectID;
        #endregion

        #region CONSTRUCTORS
        public ProjectStatusForm()
        {
            InitializeComponent();
            ProjectComboBox.DataSource = null;
            DescriptionListBox.DataSource = null;
        }
        #endregion

        #region EVENTS
        #region BackButton_Click
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ProjectStatusForm_Load
        private void ProjectStatusForm_Load(object sender, EventArgs e)
        {
            ProjectComboBox.Items.Clear();
            DescriptionListBox.Items.Clear();
            FillProjectComboBox();
        }
        #endregion


        #region ProjectComboBox_SelectedIndexChanged
        private void ProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < _projectList.Count(); i++)
            {
                if (ProjectComboBox.SelectedIndex >= 0 && ProjectComboBox.SelectedIndex == i)
                {
                    DescriptionListBox.Items.Clear();
                    DescriptionListBox.Items.Add((_projectList[i] as ProjectDTO).Description);
                    _projectID = (ProjectComboBox.SelectedItem as ProjectDTO).ProjectID;
                    StatusBox.Text = (ProjectComboBox.SelectedItem as ProjectDTO).Status.ToString();
                }
            }
            
        }
        #endregion 

        private void OnGetStatus()
        {
            ProjectComboBox.Items.Clear();
            DescriptionListBox.Items.Clear();
            StatusBox.Clear();
            FillProjectComboBox();
            ProjectComboBox.Text = "";
            UpdateStatusTextBox.Text = "";
        }

        #region UpdateStatusButton_Click
        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            _service.UpdateProjectStatus(Convert.ToDouble(UpdateStatusTextBox.Text), _projectID);
            MessageBox.Show("Success!");
            OnGetStatus();
        }
        #endregion
        #endregion

        #region METHODS
        #region FillProjectComboBox
        private void FillProjectComboBox()
        {
            foreach (var project in _service.FillProjectComboBox(GlobalVariables.CurrentUser.EmployeeID))
            {
                ProjectDTO projectDTO = new ProjectDTO();

                projectDTO.CustomerID = Convert.ToInt32(project.CustomerID);
                projectDTO.Status = project.Status;
                projectDTO.Description = project.Description;
                projectDTO.ProjectID = project.ProjectID;
                projectDTO.ProjectName = project.ProjectName;
                projectDTO.StartDate = project.StartDate;

                _projectList.Add(projectDTO);
            }


            foreach (var item in _service.FillProjectComboBox(GlobalVariables.CurrentUser.EmployeeID))
            {
                ProjectComboBox.Items.Add(item);
            }
            ProjectComboBox.DisplayMember = "ProjectName";
        }
        #endregion
        #endregion
    }
}
