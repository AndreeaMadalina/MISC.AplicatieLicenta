using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class PriorityMap : EntityTypeConfiguration<Priority>
    {
        public PriorityMap()
        {
            // Primary Key
            this.HasKey(t => t.PriorityID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Priority");
            this.Property(t => t.PriorityID).HasColumnName("PriorityID");
            this.Property(t => t.PriorityLevel).HasColumnName("PriorityLevel");
        }
    }
}
