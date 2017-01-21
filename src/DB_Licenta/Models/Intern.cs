using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Intern
    {
        public int InternID { get; set; }
        public int ApplicantID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Observation { get; set; }
        public virtual Applicant Applicant { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
