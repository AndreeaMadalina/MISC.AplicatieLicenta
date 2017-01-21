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

namespace ClientLicenta_GUI.MainForms.InsertIntoDatabase
{
    public partial class NewTaskForm : Form
    {
        private Service1Client _service = new Service1Client();
        public NewTaskForm()
        {
            InitializeComponent();
        }

        private void simpleButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            //if(_service.InsertTask())
            {

            }
        }
    }
}
