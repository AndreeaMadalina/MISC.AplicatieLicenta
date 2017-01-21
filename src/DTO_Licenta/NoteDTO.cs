using DTO_Licenta;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public class NoteDTO
    {
        [DataMember]
        public int NoteID { get; set; }
        [DataMember]
        public System.DateTime Date { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public virtual LoginDTO Login { get; set; }
    }
}
