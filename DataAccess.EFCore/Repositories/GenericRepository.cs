using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.EFCore.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly RepositoryContext _repositoryContext;
    protected DbSet<T> _dbSet;

    public GenericRepository(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression) //TODO Ingen await?
    { 
        return _repositoryContext.Set<T>().Where(expression);
    }

    public virtual async Task<IEnumerable<T>> GetAll()
    {
        return await _repositoryContext.Set<T>().ToListAsync();
    }

    public virtual async Task<T> GetById(int id)
    {
        return await _repositoryContext.Set<T>().FindAsync(id);
    }

    public virtual async Task<T> Insert(T entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        await _repositoryContext.Set<T>().AddAsync(entity);
        return entity;
    }

    public virtual async Task<T> Update(T entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        _repositoryContext.Set<T>().Update(entity); //TODO Ingen await/async?
        return entity;
    }

    public virtual async Task<T> Delete(T entity) //TODO Ingen await?
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        _repositoryContext.Set<T>().Remove(entity);
        return entity;
    }
}

