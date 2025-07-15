using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BeachMatch.Infrastructure.Persistence
{
    public class BeachMatchDbContextFactory : IDesignTimeDbContextFactory<BeachMatchDbContext>
    {
        public BeachMatchDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<BeachMatchDbContext>();
            optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));

            return new BeachMatchDbContext(optionsBuilder.Options);
        }
    }
}