using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class RegistrationDTO
    {
        [DataMember]
        public int RegistrationID { get; set; }
        [DataMember]
        public int ApplicantID { get; set; }
        [DataMember]
        public Nullable<int> JobID { get; set; }
        [DataMember]
        public Nullable<int> DepartmentID { get; set; }
        [DataMember]
        public System.DateTime AppliedDate { get; set; }
        [DataMember]
        public string Observation { get; set; }
        [DataMember]
        public virtual ApplicantDTO Applicant { get; set; }
        [DataMember]
        public virtual DepartmentDTO Department { get; set; }
        [DataMember]
        public virtual JobDTO Job { get; set; }
    }
}
