using System.Linq.Expressions;

namespace JsonWebToken.API.Core.Application.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filterExpression);
        Task CreateAsync(T entity); 
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
