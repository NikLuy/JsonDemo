using JsonDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace JsonDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Charger> Chargers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Charger>()
                .OwnsOne(c => c.Subjekt, s => s.ToJson())
                .OwnsOne(c => c.Zustell_Subjekt, s => s.ToJson());
        }
    }
}
