using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Task
    {
        public int TaskID { get; set; }
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
        public string TaskName { get; set; }
        public bool Status { get; set; }
        public string Observations { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
