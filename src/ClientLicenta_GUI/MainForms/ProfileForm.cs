using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLicenta_GUI.ServiceReference1;

namespace ClientLicenta_GUI
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            Service1Client service = new Service1Client();
            this.UsernameLabel.Text = GlobalVariables.CurrentUser.Username;
            string name = string.Format("{0} {1}", GlobalVariables.CurrentUser.Employee.FirstName, GlobalVariables.CurrentUser.Employee.LastName);
            this.NameLabel.Text = name;
            //this.JobLabel.Text = GlobalVariables.CurrentUser.Employee.Job.JobTitle;
            this.BirthDateLabel.Text = GlobalVariables.CurrentUser.Employee.BirthDate.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
