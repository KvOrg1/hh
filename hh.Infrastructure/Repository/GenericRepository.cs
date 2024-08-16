using hh.Infrastructure.Contexts;

namespace hh.Infrastructure.Repository;

public class GenericRepository<TEntity, Key> : IGenericRepository<TEntity,Key>
    where TEntity : class
{
    private readonly AppDbContext appDbContext;

    public GenericRepository(AppDbContext appDbContext) =>
        this.appDbContext =appDbContext;
    
    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var entityDb = await appDbContext.AddAsync<TEntity>(entity);

        await SaveChangesAsync();

        return entityDb.Entity;
    }

    public  IQueryable<TEntity> SelectAll()
    {
        return this.appDbContext.Set<TEntity>();
    }

    public async Task<TEntity> SelectByIdAsync(Key id)
    {
        return await this.appDbContext.Set<TEntity>().FindAsync(id);
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var updatetEntity = this.appDbContext.Update<TEntity>(entity);
        await SaveChangesAsync();

        return updatetEntity.Entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        var updatetEntity = this.appDbContext
            .Set<TEntity>()
            .Remove(entity);

        await SaveChangesAsync();

        return updatetEntity.Entity;
    }

    public async ValueTask<int> SaveChangesAsync()
    {
        return await this.appDbContext.SaveChangesAsync();
    }
}

