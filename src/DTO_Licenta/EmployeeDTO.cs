using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class EmployeeDTO
    {
        public EmployeeDTO()
        {
            this.Holidays = new List<HolidayDTO>();
            this.Interns = new List<InternDTO>();
            this.Logins = new List<LoginDTO>();
            this.Projects = new List<ProjectDTO>();
            this.Tasks = new List<TaskDTO>();
        }

        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public int JobID { get; set; }
        [DataMember]
        public int DepartmentID { get; set; }
        [DataMember]
        public Nullable<long> PNC { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public System.DateTime BirthDate { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Studies { get; set; }
        [DataMember]
        public System.DateTime HireDate { get; set; }
        [DataMember]
        public string Nationality { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public int Salary { get; set; }
        [DataMember]
        public int FileNumber { get; set; }
        [DataMember]
        public virtual DepartmentDTO Department { get; set; }
        [DataMember]
        public virtual JobDTO Job { get; set; }
        [DataMember]
        public virtual ICollection<HolidayDTO> Holidays { get; set; }
        [DataMember]
        public virtual ICollection<InternDTO> Interns { get; set; }
        [DataMember]
        public virtual ICollection<LoginDTO> Logins { get; set; }
        [DataMember]
        public virtual ICollection<ProjectDTO> Projects { get; set; }
        [DataMember]
        public virtual ICollection<TaskDTO> Tasks { get; set; }
    }
}
