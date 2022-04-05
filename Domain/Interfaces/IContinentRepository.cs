using Domain.Entities;

namespace Domain.Interfaces;

public interface IContinentRepository : IGenericRepository<Continent>
{
    public Task<IEnumerable<Continent>> GetDetailedCountryList(int id);
}
