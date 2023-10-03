using PhoneNumberAPI.Data;
using static PhoneNumberAPI.Data.Models;

namespace PhoneNumberAPI.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CountryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Country GetCountryByCode(string countryCode)
        {
            return _dbContext.Countries.FirstOrDefault(c => c.CountryCode == countryCode)!;
        }
    }


}
