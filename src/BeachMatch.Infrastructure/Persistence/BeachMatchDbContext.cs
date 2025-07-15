using BeachMatch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeachMatch.Infrastructure.Persistence
{
    public class BeachMatchDbContext : DbContext
    {
        public BeachMatchDbContext(DbContextOptions<BeachMatchDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players => Set<Player>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(p => p.Id).ValueGeneratedOnAdd();
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
            });

        }
    }
}