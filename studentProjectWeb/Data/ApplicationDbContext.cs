using Microsoft.EntityFrameworkCore;
using studentProjectWeb.Models.Entities;

namespace studentProjectWeb.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
    }
}
