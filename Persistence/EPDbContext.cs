using EntityPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityPractice.Persistence
{
    public class EPDbContext : DbContext
    {
        public EPDbContext(DbContextOptions<EPDbContext> options) : base(options)
        { 
        }
        public DbSet<Make> Makes { get; set; }
    }
}