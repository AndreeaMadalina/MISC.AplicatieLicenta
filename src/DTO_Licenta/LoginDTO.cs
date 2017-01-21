using DB_Licenta.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class LoginDTO
    {
        [DataMember]
        public int LoginID { get; set; }
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int SecurityLevel { get; set; }
        [DataMember]
        public virtual EmployeeDTO Employee { get; set; }
        [DataMember]
        public virtual NoteDTO Note { get; set; }
    }
}
