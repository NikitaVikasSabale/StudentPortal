using Microsoft.EntityFrameworkCore;
using StudentPortal1.Web.Models.Entities;

namespace StudentPortal1.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
