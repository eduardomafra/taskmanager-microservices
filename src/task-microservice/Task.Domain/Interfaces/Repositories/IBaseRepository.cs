using System.Linq.Expressions;

namespace Task.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        System.Threading.Tasks.Task AddAsync(TEntity entity);
        System.Threading.Tasks.Task RemoveAsync(TEntity entity);
        System.Threading.Tasks.Task UpdateAsync(TEntity entity);
    }
}
