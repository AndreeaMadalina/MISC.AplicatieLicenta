using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class RegistrationMap : EntityTypeConfiguration<Registration>
    {
        public RegistrationMap()
        {
            // Primary Key
            this.HasKey(t => t.RegistrationID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Registration");
            this.Property(t => t.RegistrationID).HasColumnName("RegistrationID");
            this.Property(t => t.ApplicantID).HasColumnName("ApplicantID");
            this.Property(t => t.JobID).HasColumnName("JobID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.AppliedDate).HasColumnName("AppliedDate");
            this.Property(t => t.Observation).HasColumnName("Observation");

            // Relationships
            this.HasRequired(t => t.Applicant)
                .WithMany(t => t.Registrations)
                .HasForeignKey(d => d.ApplicantID);
            this.HasOptional(t => t.Department)
                .WithMany(t => t.Registrations)
                .HasForeignKey(d => d.DepartmentID);
            this.HasOptional(t => t.Job)
                .WithMany(t => t.Registrations)
                .HasForeignKey(d => d.JobID);

        }
    }
}
