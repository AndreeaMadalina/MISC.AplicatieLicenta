using DB_Licenta.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class TaskDTO
    {
        [DataMember]
        public int TaskID { get; set; }
        [DataMember]
        public int ProjectID { get; set; }
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string TaskName { get; set; }
        [DataMember]
        public bool Status { get; set; }
        [DataMember]
        public string Observations { get; set; }
        [DataMember]
        public int PriorityID { get; set; }
        [DataMember]
        public virtual EmployeeDTO Employee { get; set; }
        [DataMember]
        public virtual PriorityDTO Priority { get; set; }
        [DataMember]
        public virtual ProjectDTO Project { get; set; }
    }
}
