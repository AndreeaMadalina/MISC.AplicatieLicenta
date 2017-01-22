using ClientLicenta_GUI.ServiceReference1;
using ClientLicenta_GUI.UserControls;
using DevExpress.XtraEditors.Repository;
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
    public partial class TasksForm : Form
    {
        private Service1Client _service = new Service1Client();
        public TasksForm()
        {
            InitializeComponent();
            //TaskGridView.Columns.Clear();
            //TaskGridControl.DataSource = null;
            this.Load +=TasksForm_Load;
        }

        void TasksForm_Load(object sender, EventArgs e)
        {
            //TaskGridView.Columns.Clear();
            //TaskGridControl.DataSource = null;
            //TaskGridView.OptionsBehavior.AutoPopulateColumns = true;
            //TaskGridControl.DataSource = _service.FillTaskGrid(GlobalVariables.CurrentUser.EmployeeID).Select(x => new
            //{
            //    ID = x.TaskID,
            //    TaskName = x.TaskName,
            //    Priority = x.Priority.PriorityLevel,
            //    Project = x.Project.ProjectName,
            //    Status = x.Status,
            //    Observations = x.Observations
            //}).ToList();

            //TaskGridView.BestFitColumns(true);

            //TaskGridView.RefreshData();
            //RepositoryItemCheckEdit status = new RepositoryItemCheckEdit();
            //TaskGridView.Columns["Status"].ColumnEdit = status;            TaskGridView.Columns["Status"].UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            
            //TaskGridView.Columns.Add(
            //    new DevExpress.XtraGrid.Columns.GridColumn()
            //    {
            //        Caption = "Status",
            //        ColumnEdit = new RepositoryItemCheckEdit() { },
            //        VisibleIndex = 3,
            //        UnboundType = DevExpress.Data.UnboundColumnType.Boolean
            //    }
            //    );

            //DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectnew = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            //TaskGridView.Columns.Add(selectnew);
            //TaskGridView.Columns["Status"].ColumnEdit = selectnew;
            //selectnew.NullText = "";
            //selectnew.ValueChecked = true;
            //selectnew.ValueUnchecked = false;
            //selectnew.ValueGrayed = "-";
            OnGetTasks();
        }

        private void OnGetTasks()
        {
            // Se creaza o lista de task-uri de tipul DTO
            List<TaskDTO> taskList = new List<TaskDTO>();
            // Pentru fiecare task al user-ului curent, returnat de catre serviciu, se copiaza detaliile acestuia
            foreach (var item in _service.FillTaskGrid(GlobalVariables.CurrentUser.EmployeeID))
            {
                TaskDTO task = new TaskDTO();
                ProjectDTO projetc = new ProjectDTO();
                task.Project = projetc;
                task.EmployeeID = item.EmployeeID;
                task.Observations = item.Observations;
                task.Project.ProjectName = item.Project.ProjectName;
                task.ProjectID = item.ProjectID;
                task.TaskID = item.TaskID;
                task.TaskName = item.TaskName;
                
                // Se adauga fiecare task in lista creata mai sus
                taskList.Add(task);
            }

            // Se sterge forma
            TaskPanel.Controls.Clear();
            // Se creaza un vector de userControale
            ucTaskUpdate[] uc = new ucTaskUpdate[20];
            // Se itereaza prin lista de task-uri
            for (int i = 0; i < taskList.Count; i++)
            {
                // Pentru fiecare task, se adauga un nou element in vectorul creat mai sus (uc)
                uc[i] = new ucTaskUpdate(taskList[i]);
                // Se adauga apoi controlul pe forma
                TaskPanel.Controls.Add(uc[i]);
                // Se seteaza marimea si locatia pe forma respectiva
                uc[i].Size = new System.Drawing.Size(TaskPanel.Width, 25);
                uc[i].Location = new Point(3, i * 30);
            }
        }

        private void BackSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateSimpleButton_Click(object sender, EventArgs e)
        {
            foreach (Control item in TaskPanel.Controls)
            {
                var StatusCheckBox = item as ucTaskUpdate;
                if (StatusCheckBox.Done)
                {
                    StatusCheckBox.Task.Status = true;
                    if (_service.UpdateStatusTask(StatusCheckBox.Task))
                    {
                        MessageBox.Show("Success!");
                        OnGetTasks();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }

           
            
        }
    }
}
