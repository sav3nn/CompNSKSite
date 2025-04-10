using Microsoft.EntityFrameworkCore;

namespace CompNSKSite.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Feedback> Feedback { get; set; }

        public DbSet<Product> Product { get; set; }
        

    }

}
