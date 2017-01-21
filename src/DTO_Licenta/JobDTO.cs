using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class JobDTO
    {
        public JobDTO()
        {
            this.Employees = new List<EmployeeDTO>();
            this.Registrations = new List<RegistrationDTO>();
        }

        [DataMember]
        public int JobID { get; set; }
        [DataMember]
        public string JobTitle { get; set; }
        [DataMember]
        public virtual ICollection<EmployeeDTO> Employees { get; set; }
        [DataMember]
        public virtual ICollection<RegistrationDTO> Registrations { get; set; }
    }
}
