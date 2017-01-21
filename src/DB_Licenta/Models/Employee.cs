using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.Holidays = new List<Holiday>();
            this.Interns = new List<Intern>();
            this.Logins = new List<Login>();
            this.Projects = new List<Project>();
            this.Tasks = new List<Task>();
        }

        public int EmployeeID { get; set; }
        public int JobID { get; set; }
        public int DepartmentID { get; set; }
        public Nullable<long> PNC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Studies { get; set; }
        public System.DateTime HireDate { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int FileNumber { get; set; }
        public virtual Department Department { get; set; }
        public virtual Job Job { get; set; }
        public virtual ICollection<Holiday> Holidays { get; set; }
        public virtual ICollection<Intern> Interns { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
