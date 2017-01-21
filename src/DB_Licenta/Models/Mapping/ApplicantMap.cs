using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class ApplicantMap : EntityTypeConfiguration<Applicant>
    {
        public ApplicantMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplicantID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Studies)
                .IsRequired();

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(20);

            this.Property(t => t.Mail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Nationality)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Applicant");
            this.Property(t => t.ApplicantID).HasColumnName("ApplicantID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Studies).HasColumnName("Studies");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.Mail).HasColumnName("Mail");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Nationality).HasColumnName("Nationality");
        }
    }
}
