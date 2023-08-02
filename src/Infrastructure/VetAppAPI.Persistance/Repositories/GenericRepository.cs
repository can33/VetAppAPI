using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VetAppAPI.Application.Repositories;
using VetAppAPI.Persistance.Contexts;

namespace VetAppAPI.Persistance.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
{
    protected readonly VetAppDbContext _context;

    public GenericRepository(VetAppDbContext context)
    {
        _context = context;
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
    }

    public async Task<T> GetByIdAsync(Guid id)
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
        await _context.SaveChangesAsync();
    }
}
