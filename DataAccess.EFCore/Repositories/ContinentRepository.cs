using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Repositories;

public class ContinentRepository : GenericRepository<Continent>, IContinentRepository
{
    public ContinentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public async Task<IEnumerable<Continent>> GetDetailedCountryList(int id)
    {
        var list = await _repositoryContext.Continents
            .Include(x => x.Countries)
            .Where(x => x.Id == id)
            .ToListAsync();
        return list;
    }
}
