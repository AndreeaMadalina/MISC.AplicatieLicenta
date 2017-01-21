using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Priority
    {
        public Priority()
        {
            this.Tasks = new List<Task>();
        }

        public int PriorityID { get; set; }
        public int PriorityLevel { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
