using static PhoneNumberAPI.Data.Models;

namespace PhoneNumberAPI.Repository
{
    public interface ICountryDetailRepository
    {
        List<CountryDetail> GetDetailsByCountryId(int countryId);
    }
}
