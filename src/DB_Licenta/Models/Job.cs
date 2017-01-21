using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Job
    {
        public Job()
        {
            this.Employees = new List<Employee>();
            this.Registrations = new List<Registration>();
        }

        public int JobID { get; set; }
        public string JobTitle { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
