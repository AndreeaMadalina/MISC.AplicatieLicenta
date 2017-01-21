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
    public partial class LoginForm : Form
    {
        #region VARIABLES
        private Service1Client service = new Service1Client();
        #endregion

        #region CONSTRUCTOR
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS
        #region LoginForm_Load
        void LoginForm_Load(object sender, EventArgs e)
        {
            GlobalVariables.CurrentUser = null;
        }
        #endregion

        #region PasswordTextBox_KeyDown
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginSimpleButton_Click(sender, e);
            }
        }
        #endregion

        #region LoginSimpleButton_Click
        private void LoginSimpleButton_Click(object sender, EventArgs e)
        {
            var user = service.Authenticate(UsernameTextBox.Text, PasswordTextBox.Text);
            if (user != null)
            {
                GlobalVariables.CurrentUser = user;

                switch (GlobalVariables.CurrentUser.SecurityLevel)
                {
                    case 1:
                        MenuForm main1 = new MenuForm();
                        main1.checkUser(1);
                        main1.Show();
                        this.Hide();
                        break;
                    case 2:
                        MenuForm main2 = new MenuForm();
                        main2.checkUser(2);
                        main2.Show();
                        this.Hide();
                        break;
                    case 3:
                        MenuForm main3 = new MenuForm();
                        main3.checkUser(3);
                        main3.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Username or Passwor wrong!");
            }
        }
        #endregion

        #region CancelSimpleButton_Click
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
    }
}
