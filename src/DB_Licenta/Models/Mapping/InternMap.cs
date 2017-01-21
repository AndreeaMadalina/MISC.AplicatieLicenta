using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class InternMap : EntityTypeConfiguration<Intern>
    {
        public InternMap()
        {
            // Primary Key
            this.HasKey(t => t.InternID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Intern");
            this.Property(t => t.InternID).HasColumnName("InternID");
            this.Property(t => t.ApplicantID).HasColumnName("ApplicantID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Observation).HasColumnName("Observation");

            // Relationships
            this.HasRequired(t => t.Applicant)
                .WithMany(t => t.Interns)
                .HasForeignKey(d => d.ApplicantID);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.Interns)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
