using System.Linq.Expressions;

namespace BcProje.Core.Abstract
{
    public interface IGenericRepository<T> where T : class, IBaseEntity, new()
    {
        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAsync(Expression<Func<T,bool>> filter = null);

        Task<bool> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int id);
    }
}