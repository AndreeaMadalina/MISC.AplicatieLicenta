using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Note
    {
        public int NoteID { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public virtual Login Login { get; set; }
    }
}
