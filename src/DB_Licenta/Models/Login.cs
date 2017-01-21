using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Login
    {
        public Login()
        {
            this.Notes = new List<Note>();
        }

        public int LoginID { get; set; }
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int SecurityLevel { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
