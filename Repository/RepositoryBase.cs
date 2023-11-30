using Contracts;
using DataContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository;
public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private TeamDbContext dbContext;
    public RepositoryBase(TeamDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Add(T entity)
    {
        dbContext.Set<T>().Add(entity);
    }

    public IQueryable<T> FindAll(bool trackChanges)
    {
        return trackChanges ? dbContext.Set<T>() : dbContext.Set<T>().AsNoTracking();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges)
    {
        return trackChanges ? dbContext.Set<T>().Where(condition) : dbContext.Set<T>().Where(condition).AsNoTracking();
    }

    public void Remove(T entity)
    {
        dbContext.Set<T>().Remove(entity);
    }

    public void Save()
    {
        dbContext.SaveChanges();
    }

    public void Update(T entity)
    {
        dbContext.Set<T>().Update(entity);
    }
}
