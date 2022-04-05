using Domain.Entities;

namespace Domain.Interfaces;

public interface ICityRepository : IGenericRepository<City>
{
    Task<IEnumerable<City>> GetDetailedList();

}
