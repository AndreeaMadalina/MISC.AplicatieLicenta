using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjectID);

            // Properties
            this.Property(t => t.ProjectName)
                .IsRequired();

            this.Property(t => t.Technology)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Project");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.Technology).HasColumnName("Technology");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Projects)
                .HasForeignKey(d => d.CustomerID);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.Projects)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
