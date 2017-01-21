using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DB_Licenta.Models.Mapping;

namespace DB_Licenta.Models
{
    public partial class DatabaseLicentaContext : DbContext
    {
        static DatabaseLicentaContext()
        {
            Database.SetInitializer<DatabaseLicentaContext>(null);
        }

        public DatabaseLicentaContext()
            : base("Name=DatabaseLicentaContext")
        {
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicantMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new HolidayMap());
            modelBuilder.Configurations.Add(new InternMap());
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new NewsMap());
            modelBuilder.Configurations.Add(new NoteMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new RegistrationMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TaskMap());
        }
    }
}
