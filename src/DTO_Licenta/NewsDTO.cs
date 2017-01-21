using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class NewsDTO
    {
        [DataMember]
        public int NewsID { get; set; }
        [DataMember]
        public System.DateTime Date { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
