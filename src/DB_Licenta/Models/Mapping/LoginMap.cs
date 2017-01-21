using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Licenta.Models.Mapping
{
    public class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            // Primary Key
            this.HasKey(t => t.LoginID);

            // Properties
            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Login");
            this.Property(t => t.LoginID).HasColumnName("LoginID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.SecurityLevel).HasColumnName("SecurityLevel");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.Logins)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
