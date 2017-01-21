using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.Projects = new List<Project>();
        }

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Institution { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
