using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class DepartmentDTO
    {
        public DepartmentDTO()
        {
            this.Employees = new List<EmployeeDTO>();
            this.Registrations = new List<RegistrationDTO>();
        }

        [DataMember]
        public int DepartmentID { get; set; }
        [DataMember]
        public string DepartmentName { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public virtual ICollection<EmployeeDTO> Employees { get; set; }
        [DataMember]
        public virtual ICollection<RegistrationDTO> Registrations { get; set; }
    }
}
