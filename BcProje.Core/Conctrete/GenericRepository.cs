using BcProje.Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BcProje.Core.Conctrete
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
        where TEntity : class, IBaseEntity, new()
        where TContext : DbContext, new()
    {
        
        public async Task<bool> CreateAsync(TEntity entity)
        {
            using TContext _context = new TContext();
            await _context.AddAsync<TEntity>(entity);
            int result = await _context.SaveChangesAsync();

            return Convert.ToBoolean(result);

        }

        public async Task<bool> DeleteAsync(int id)
        {
            using TContext _context = new TContext();
            TEntity entity = await _context.FindAsync<TEntity>(id);
            if (entity != null)
            {
                await Task.Run(() => _context.Remove(entity));
                return true;
            }
            return false;
        }


        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using TContext _context = new TContext();
            if (filter is null)
            {
                return await _context.Set<TEntity>().ToListAsync();

            }
            return await _context.Set<TEntity>().Where(filter).ToListAsync();

        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            using TContext _context = new TContext();
            var result = await _context.FindAsync<TEntity>(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                return new TEntity();
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity model)
        {
            using (TContext _context = new TContext())
            {
                var UpdatedModel = _context.Entry(model);
                UpdatedModel.State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return UpdatedModel as TEntity;
            }
        }
    }
}
