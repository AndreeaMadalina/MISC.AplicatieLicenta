using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class NewsMap : EntityTypeConfiguration<News>
    {
        public NewsMap()
        {
            // Primary Key
            this.HasKey(t => t.NewsID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("News");
            this.Property(t => t.NewsID).HasColumnName("NewsID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
