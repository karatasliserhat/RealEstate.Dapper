using System.Linq.Expressions;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);

    }
}
