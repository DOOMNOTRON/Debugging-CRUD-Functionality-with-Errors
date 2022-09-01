using Microsoft.EntityFrameworkCore;

namespace CPW219_CRUD_Troubleshooting.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
// To add the database locally use this command "Add-Migration" "DesiredNameOfMiigration" in the Package Manager Console
// Then use "Update-database"