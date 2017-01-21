using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Holiday
    {
        public int HolidayID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Type { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
