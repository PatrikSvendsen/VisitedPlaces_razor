using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Repositories;

public class CountryRepository : GenericRepository<Country>, ICountryRepository
{
    public CountryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
        
    }

    public async Task<IEnumerable<Country>> GetDetailedCountryList()
    {
        var list = await _repositoryContext.Countries
            .Include(ci => ci.Cities)
            .ToListAsync();
        return list;
        
    }
}
