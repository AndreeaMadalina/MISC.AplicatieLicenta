using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Project
    {
        public Project()
        {
            this.Tasks = new List<Task>();
        }

        public int ProjectID { get; set; }
        public int CustomerID { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string Technology { get; set; }
        public Nullable<double> Status { get; set; }
        public Nullable<int> Price { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
