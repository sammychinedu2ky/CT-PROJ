using PhoneNumberAPI.Data;
using PhoneNumberAPI.Repository;

namespace PhoneNumberAPI.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            CountryRepository = new CountryRepository(_dbContext);
            CountryDetailRepository = new CountryDetailRepository(_dbContext);
        }

        public ICountryRepository CountryRepository { get; }
        public ICountryDetailRepository CountryDetailRepository { get; }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }

}

