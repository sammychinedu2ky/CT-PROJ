using Microsoft.EntityFrameworkCore;
using static PhoneNumberAPI.Data.Models;
namespace PhoneNumberAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetail> CountryDetails { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            CountrySeeder.Seed(modelBuilder);
            CountryDetailSeeder.Seed(modelBuilder);
        }

    }
}
