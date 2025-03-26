namespace unit_of_work.Data;

public interface IGenericRepo<TEntity> where TEntity : class
{
    public Task<List<TEntity>> GetAllAsync(int pageIndex, int pageSize);
    
    public Task<TEntity> GetAsync(int id);
    
    public Task InsertAsync(TEntity entity);
    
    public Task UpdateAsync(TEntity entity);
    
    public Task DeleteAsync(TEntity entity);
}