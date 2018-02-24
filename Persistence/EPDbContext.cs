using Microsoft.EntityFrameworkCore;

namespace EntityPractice.Persistence
{
    public class EPDbContext : DbContext
    {
        public EPDbContext(DbContextOptions<EPDbContext> options) : base(options)
        { 
        }
    }
}