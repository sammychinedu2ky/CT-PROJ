using PhoneNumberAPI.Repository;

namespace PhoneNumberAPI.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICountryRepository CountryRepository { get; }
        ICountryDetailRepository CountryDetailRepository { get; }
        void SaveChanges();
    }
}
