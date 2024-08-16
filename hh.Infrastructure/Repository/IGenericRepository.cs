using System.Reflection.Metadata.Ecma335;

namespace hh.Infrastructure.Repository
{
    public interface IGenericRepository<TEntity,Key>
    {
        Task<TEntity> InsertAsync(TEntity entity);
        IQueryable<TEntity> SelectAll();
        Task<TEntity> SelectByIdAsync(Key id);

        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
    }
}
