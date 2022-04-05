using Domain.Entities;
using Domain.Interfaces;

namespace DataAccess.EFCore.Repositories;

public class CountryRegionRepository : GenericRepository<CountryRegion>, ICountryRegionRepository
{
    public CountryRegionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}
