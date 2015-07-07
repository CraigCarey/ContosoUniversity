using ContosoUniversity.Models;
using System.Data.Entity;   // .DbContext
using System.Data.Entity.ModelConfiguration.Conventions;

// DAL: Data Access Layer
namespace ContosoUniversity.DAL
{
    // Coordinates Entity Framework functionality for a given data model
    public class SchoolContext : DbContext
    {
        // The name of the connection string (see Web.config) is passed in to the constructor
        public SchoolContext()
            : base("SchoolContext") {
        }

        // Specify which entities are included in the data model
        // This creates a DbSet property for each entity set
        // In Entity Framework terminology, an entity set typically corresponds to a database table, and an entity corresponds to a row in the table
        // Could have omitted the DbSet<Enrollment> and DbSet<Course> statements and it would work the same.
        // The Entity Framework would include them implicitly because the Student entity references the Enrollment entity and the Enrollment entity references the Course entity
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // prevents table names from being pluralized
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}