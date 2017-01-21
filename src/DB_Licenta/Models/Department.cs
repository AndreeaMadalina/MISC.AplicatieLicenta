using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Department
    {
        public Department()
        {
            this.Employees = new List<Employee>();
            this.Registrations = new List<Registration>();
        }

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
