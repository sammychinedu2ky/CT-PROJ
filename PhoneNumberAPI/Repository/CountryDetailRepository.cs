using PhoneNumberAPI.Data;
using static PhoneNumberAPI.Data.Models;

namespace PhoneNumberAPI.Repository
{
    public class CountryDetailRepository : ICountryDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CountryDetailRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CountryDetail> GetDetailsByCountryId(int countryId)
        {
            return _dbContext.CountryDetails.Where(cd => cd.CountryId == countryId).ToList();
        }
    }

}
