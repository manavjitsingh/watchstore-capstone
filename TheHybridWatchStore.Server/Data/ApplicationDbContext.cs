using Microsoft.EntityFrameworkCore;
using TheHybridWatchStore.Server.Data;
using TheHybridWatchStore.Server.Data.Models;

namespace TheHybridWatchStore.Server.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Watch> Watches { get; set; }
        public DbSet<WatchSpecs> WatchSpecs { get; set; }
        public DbSet<WatchImage> WatchImages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Call the Seed method to apply seeding
            modelBuilder.Seed();
        }

    }
}
