using Microsoft.EntityFrameworkCore;

namespace unit_of_work.Data;

public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
{
    private AppDbContext _dbcontext;
    public GenericRepo(AppDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<List<TEntity>> GetAllAsync(int pageIndex, int pageSize)
    {
        return await _dbcontext.Set<TEntity>()
            .AsNoTracking()
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
    public async Task<TEntity> GetAsync(int id)
    {
        return await _dbcontext.Set<TEntity>().FindAsync(id);
    }
    public async Task InsertAsync(TEntity entity)
    {
        _dbcontext.Set<TEntity>().AddAsync(entity);
        //var entry = _dbcontext.Set<TEntity>().AddAsync(entity);
        //await _dbcontext.SaveChangesAsync();
        //return entry.Result.Entity;
    }
    public async Task UpdateAsync(TEntity entity)
    {
        _dbcontext.Set<TEntity>().Update(entity);
        //_dbcontext.Set<TEntity>().Update(entity);
        //return await _dbcontext.SaveChangesAsync();
    }
    public async Task DeleteAsync(TEntity entity)
    {
        _dbcontext.Set<TEntity>().Remove(entity);
        //_dbcontext.Set<TEntity>().Remove(entity);
        ///return await _dbcontext.SaveChangesAsync();
    }
}