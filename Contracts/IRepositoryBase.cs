using System.Linq.Expressions;

namespace Contracts;
public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll(bool trackChanges);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges);
    void Add(T entity);
    void Remove(T entity);
    void Update(T entity);
    void Save();
}
