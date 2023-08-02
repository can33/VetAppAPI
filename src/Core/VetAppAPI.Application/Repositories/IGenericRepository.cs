using System.Linq.Expressions;

namespace VetAppAPI.Application.Repositories;

public interface IGenericRepository<T> where T : class, new()
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity);
}
