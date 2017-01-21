using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.TaskID);

            // Properties
            this.Property(t => t.TaskName)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Task");
            this.Property(t => t.TaskID).HasColumnName("TaskID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.TaskName).HasColumnName("TaskName");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Observations).HasColumnName("Observations");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.EmployeeID);
            this.HasRequired(t => t.Project)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
