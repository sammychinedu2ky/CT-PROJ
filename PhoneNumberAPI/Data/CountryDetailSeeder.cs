using Microsoft.EntityFrameworkCore;
using static PhoneNumberAPI.Data.Models;

namespace PhoneNumberAPI.Data
{
    internal class CountryDetailSeeder
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryDetail>().HasData(
                new CountryDetail { Id = 1, CountryId = 1, OperatorCode = "MTN NG", Operator = "MTN Nigeria" },
                new CountryDetail { Id = 2, CountryId = 1, OperatorCode = "ANG", Operator = "Airtel Nigeria" },
                new CountryDetail { Id = 3, CountryId = 1, OperatorCode = "ETN", Operator = "9 Mobile Nigeria" },
                new CountryDetail { Id = 4, CountryId = 1, OperatorCode = "GLO NG", Operator = "Globacom Nigeria" },
                new CountryDetail { Id = 5, CountryId = 2, OperatorCode = "Vodafone GH", Operator = "Vodafone Ghana" },
                new CountryDetail { Id = 6, CountryId = 2, OperatorCode = "MTN Ghana", Operator = "MTN Ghana" },
                new CountryDetail { Id = 7, CountryId = 2, OperatorCode = "Tigo Ghana", Operator = "Tigo Ghana" },
                new CountryDetail { Id = 8, CountryId = 3, OperatorCode = "MTN Benin", Operator = "MTN Benin" },
                new CountryDetail { Id = 9, CountryId = 3, OperatorCode = "Moov Benin", Operator = "Moov Benin" },
                new CountryDetail { Id = 10, CountryId = 4, OperatorCode = "MTN Cote d'Ivoire", Operator = "MTN Cote d'Ivoire" }
            );
        }
    }
}