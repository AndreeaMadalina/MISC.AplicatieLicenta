using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class CustomerDTO
    {
        public CustomerDTO()
        {
            this.Projects = new List<ProjectDTO>();
        }

        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Institution { get; set; }
        [DataMember]
        public virtual ICollection<ProjectDTO> Projects { get; set; }
    }
}
