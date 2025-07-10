using BeachMatch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeachMatch.Persistence
{
    public class BeachMatchDbContext : DbContext
    {
        public BeachMatchDbContext(DbContextOptions<BeachMatchDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players => Set<Player>();

        // Futuramente:
        // public DbSet<Match> Matches => Set<Match>();
        // public DbSet<Team> Teams => Set<Team>();
        // public DbSet<Presence> Presences => Set<Presence>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração da entidade Player
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
                entity.Property(p => p.SkillLevel).IsRequired();
            });

            // Aqui você adicionará configurações das outras entidades (Match, Team, etc.)
        }
    }
}