using Microsoft.EntityFrameworkCore.Query;

namespace MelodexLibrary.Data;

public interface IDataRepository<T> where T : class
{
    Task<T?> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null);
    Task<List<T>> GetFilteredAsync(Func<IQueryable<T>, IQueryable<T>> filter, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null);
    Task CreateAsync(T item);
    Task UpdateAsync(T item);
    Task DeleteAsync(T item);
}