using DTO_Licenta;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DB_Licenta.Models
{
    [DataContract]
    public partial class PriorityDTO
    {
        public PriorityDTO()
        {
            this.Tasks = new List<TaskDTO>();
        }

        [DataMember]
        public int PriorityID { get; set; }
        [DataMember]
        public int PriorityLevel { get; set; }
        [DataMember]
        public virtual ICollection<TaskDTO> Tasks { get; set; }
    }
}
