namespace unit_of_work.Data;

public interface IGenericRepo<TEntity> where TEntity : class
{
    public Task<List<TEntity>> GetAllAsync(int pageIndex, int pageSize);
    
    public Task<TEntity> GetAsync(int id);
    
    public ValueTask<TEntity> InsertAsync(TEntity entity);
    
    public Task<int> UpdateAsync(TEntity entity);
    
    public Task<int> DeleteAsync(TEntity entity);
}