using DataAccess.EFCore.Repositories;
using Domain.Interfaces;

namespace DataAccess.EFCore.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly RepositoryContext _repositoryContext;
    public UnitOfWork(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        Continents = new ContinentRepository(_repositoryContext);
        Countries = new CountryRepository(_repositoryContext);
        CountyRegions = new CountryRegionRepository(_repositoryContext);
        Cities = new CityRepository(_repositoryContext);
    }

    public IContinentRepository Continents { get; private set; }
    public ICountryRepository Countries { get; private set; }
    public ICountryRegionRepository CountyRegions { get; private set; }
    public ICityRepository Cities { get; private set; }

    public async Task CompleteAsync()
    {
        await _repositoryContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _repositoryContext.Dispose();
    }
}
