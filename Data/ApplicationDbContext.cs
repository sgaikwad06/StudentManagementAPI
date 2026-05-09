using Microsoft.EntityFrameworkCore;
using StudentMangementAPI.Models;


namespace StudentMangementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Student> Students { get; set; }
    }
}
