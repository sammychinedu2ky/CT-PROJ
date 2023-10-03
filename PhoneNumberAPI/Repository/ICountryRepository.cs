using static PhoneNumberAPI.Data.Models;

namespace PhoneNumberAPI.Repository
{
    public interface ICountryRepository
    {
        Country GetCountryByCode(string countryCode);
    }

}
