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
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
                entity.Property(p => p.SkillLevel).IsRequired();
            });

        }
    }
}