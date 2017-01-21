using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class InternDTO
    {
        [DataMember]
        public int InternID { get; set; }
        [DataMember]
        public int ApplicantID { get; set; }
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public System.DateTime StartDate { get; set; }
        [DataMember]
        public System.DateTime EndDate { get; set; }
        [DataMember]
        public string Observation { get; set; }
        [DataMember]
        public virtual ApplicantDTO Applicant { get; set; }
        [DataMember]
        public virtual EmployeeDTO Employee { get; set; }
    }
}
