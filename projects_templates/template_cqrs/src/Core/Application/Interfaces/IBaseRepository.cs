using System.Linq.Expressions;

namespace Application.Interfaces;

public interface IBaseRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> expression = null,
                                    bool disableTracking = true);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}