using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            // Primary Key
            this.HasKey(t => t.JobID);

            // Properties
            this.Property(t => t.JobTitle)
                .IsRequired()
                .HasMaxLength(70);

            // Table & Column Mappings
            this.ToTable("Job");
            this.Property(t => t.JobID).HasColumnName("JobID");
            this.Property(t => t.JobTitle).HasColumnName("JobTitle");
        }
    }
}
