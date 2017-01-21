using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Registration
    {
        public int RegistrationID { get; set; }
        public int ApplicantID { get; set; }
        public Nullable<int> JobID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public System.DateTime AppliedDate { get; set; }
        public string Observation { get; set; }
        public virtual Applicant Applicant { get; set; }
        public virtual Department Department { get; set; }
        public virtual Job Job { get; set; }
    }
}
