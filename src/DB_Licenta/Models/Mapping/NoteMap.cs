using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class NoteMap : EntityTypeConfiguration<Note>
    {
        public NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteID);

            // Properties
            this.Property(t => t.Description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Note");
            this.Property(t => t.NoteID).HasColumnName("NoteID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.UserID).HasColumnName("UserID");

            // Relationships
            this.HasRequired(t => t.Login)
                .WithMany(t => t.Notes)
                .HasForeignKey(d => d.UserID);

        }
    }
}
