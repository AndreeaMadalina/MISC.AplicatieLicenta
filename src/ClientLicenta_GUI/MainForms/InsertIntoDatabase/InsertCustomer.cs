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
    public partial class InsertCustomer : Form
    {
        #region Variables
        private Service1Client _service = new Service1Client();
        #endregion

        #region Constructors
        public InsertCustomer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        #region Events
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = new CustomerDTO();
            customer.Address = AddressTextEdit.Text;
            customer.Institution = InstitutionTextEdit.Text;
            customer.Mail = MailTextEdit.Text;
            customer.Name = NameTextEdit.Text;
            customer.PhoneNumber = PhoneTextEdit.Text;

            if (_service.InsertCustomer(customer))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please try again!");
            }
        }
        #endregion
        //Functia pentru a introduce doar cifre in textBox-urile PNCTextEdit,  SalaryTextEdit, FileNumberTextEdit
        #region Only numbers can be inserted
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        


    }
}
