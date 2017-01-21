using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        private string _employeeName;
        private int _employeeID;
        public Employee(string firstName, string lastName, int ID)
        {
            Name = string.Format("{0} {1}", firstName, lastName);
            this.ID = ID;
        }

        public string Name
        {
            get
            { return _employeeName; }
            set
            { _employeeName = value; }
        }

        public int ID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
    }
}
