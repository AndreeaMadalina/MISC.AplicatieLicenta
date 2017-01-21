using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO_Licenta
{
    [DataContract]
    public partial class HolidayDTO
    {
        [DataMember]
        public int HolidayID { get; set; }
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public System.DateTime StartDate { get; set; }
        [DataMember]
        public System.DateTime EndDate { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public virtual EmployeeDTO Employee { get; set; }
    }
}
