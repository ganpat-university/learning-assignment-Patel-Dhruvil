using Microsoft.EntityFrameworkCore;
using ReactProj01.Models;

namespace ReactProj01.Data
{
    public class ApplicationDbContext
       : DbContext
    {

        public DbSet<Department> Departments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
