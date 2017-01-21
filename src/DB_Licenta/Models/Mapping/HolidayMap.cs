using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class HolidayMap : EntityTypeConfiguration<Holiday>
    {
        public HolidayMap()
        {
            // Primary Key
            this.HasKey(t => t.HolidayID);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Holiday");
            this.Property(t => t.HolidayID).HasColumnName("HolidayID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Type).HasColumnName("Type");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.Holidays)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
