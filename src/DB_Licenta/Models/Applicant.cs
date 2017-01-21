using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class Applicant
    {
        public Applicant()
        {
            this.Interns = new List<Intern>();
            this.Registrations = new List<Registration>();
        }

        public int ApplicantID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Studies { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public virtual ICollection<Intern> Interns { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
