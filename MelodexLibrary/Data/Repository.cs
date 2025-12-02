using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace MelodexLibrary.Data;

public class Repository<T>(MelodexDbContext context) : IDataRepository<T> where T : class
{
    private readonly DbSet<T> _dbSet = context.Set<T>();
    
    public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

    public async Task<List<T>> GetAllAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> query = _dbSet;
        
        if (include != null)
        {
            query = include(query);
        }
        
        return await query.ToListAsync();
    }

    public async Task CreateAsync(T item)
    {
        await _dbSet.AddAsync(item);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T item)
    {
        _dbSet.Update(item);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T item)
    {
        _dbSet.Remove(item);
        await context.SaveChangesAsync();
    }
}