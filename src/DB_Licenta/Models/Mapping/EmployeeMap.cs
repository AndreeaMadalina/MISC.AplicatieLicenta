using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(20);

            this.Property(t => t.Mail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .IsRequired();

            this.Property(t => t.Studies)
                .IsRequired();

            this.Property(t => t.Nationality)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Employee");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.JobID).HasColumnName("JobID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.PNC).HasColumnName("PNC");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.Mail).HasColumnName("Mail");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Studies).HasColumnName("Studies");
            this.Property(t => t.HireDate).HasColumnName("HireDate");
            this.Property(t => t.Nationality).HasColumnName("Nationality");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Salary).HasColumnName("Salary");
            this.Property(t => t.FileNumber).HasColumnName("FileNumber");

            // Relationships
            this.HasRequired(t => t.Department)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.DepartmentID);
            this.HasRequired(t => t.Job)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.JobID);

        }
    }
}
