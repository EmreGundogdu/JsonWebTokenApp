using JsonWebToken.API.Core.Application.Interfaces;
using JsonWebToken.API.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace JsonWebToken.API.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        readonly JwtContext _context;

        public Repository(JwtContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filterExpression)
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filterExpression);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();  
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChanges();
        }
    }
}
