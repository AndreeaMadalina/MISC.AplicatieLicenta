using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class ProjectDTO
    {
        
        public ProjectDTO()
        {
            this.Tasks = new List<TaskDTO>();
        }

        [DataMember]
        public int ProjectID { get; set; }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public string ProjectName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Technology { get; set; }
        [DataMember]
        public Nullable<System.DateTime> StartDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> EndDate { get; set; }
        [DataMember]
        public Nullable<double> Status { get; set; }
        [DataMember]
        public Nullable<int> Price { get; set; }
        [DataMember]
        public Nullable<int> EmployeeID { get; set; }
        [DataMember]
        public virtual CustomerDTO Customer { get; set; }
        [DataMember]
        public virtual EmployeeDTO Employee { get; set; }
        [DataMember]
        public virtual ICollection<TaskDTO> Tasks { get; set; }
    }
}
