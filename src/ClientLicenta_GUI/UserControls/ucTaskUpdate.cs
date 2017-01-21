using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLicenta_GUI.ServiceReference1;

namespace ClientLicenta_GUI.UserControls
{
    public partial class ucTaskUpdate : UserControl
    {
        private TaskDTO _task = new TaskDTO();
        public ucTaskUpdate()
        {
            InitializeComponent();
        }

        public ucTaskUpdate(TaskDTO task)
        {
            InitializeComponent();
            this._task = task;
            TaskNameLabel.Text = task.TaskName;
            ProjectNameLabel.Text = task.Project.ProjectName;
        }

        public bool Done
        {
            get
            {
                return StatusCheckBox.Checked;
            }
        }

        public TaskDTO Task
        {
            get
            {
                return _task;
            }
            set
            {
                _task = value;
            }
        }
    }
}
