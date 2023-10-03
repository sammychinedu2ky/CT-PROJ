using Microsoft.EntityFrameworkCore;
using static PhoneNumberAPI.Data.Models;

namespace PhoneNumberAPI.Data
{
    public class CountrySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, CountryCode = "234", Name = "Nigeria", CountryIso = "NG" },
                new Country { Id = 2, CountryCode = "233", Name = "Ghana", CountryIso = "GH" },
                new Country { Id = 3, CountryCode = "229", Name = "Benin Republic", CountryIso = "BN" },
                new Country { Id = 4, CountryCode = "225", Name = "Cote d'Ivoire", CountryIso = "CIV" }
            );

        }
    }
}