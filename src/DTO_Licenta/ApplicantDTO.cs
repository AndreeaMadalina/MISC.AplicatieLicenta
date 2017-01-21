using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class ApplicantDTO
    {
        public ApplicantDTO()
        {
            this.Interns = new List<InternDTO>();
            this.Registrations = new List<RegistrationDTO>();
        }
        [DataMember]
        public int ApplicantID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Studies { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public System.DateTime BirthDate { get; set; }
        [DataMember]
        public string Nationality { get; set; }
        [DataMember]
        public virtual ICollection<InternDTO> Interns { get; set; }
        [DataMember]
        public virtual ICollection<RegistrationDTO> Registrations { get; set; }
    }
}
