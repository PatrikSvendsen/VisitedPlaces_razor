using Domain.Entities;
using Domain.Interfaces;

namespace DataAccess.EFCore.Repositories;

public class ContinentRepository : GenericRepository<Continent>, IContinentRepository
{
    public ContinentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}
