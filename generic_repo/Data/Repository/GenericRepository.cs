
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace generic_repo.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private CustomAppDbContext _db;
        public GenericRepository(CustomAppDbContext db)
        {
            this._db = db;
        }
        public IEnumerable<TEntity> GetAll(int pageNumber, int pageSize)
        {
            return _db.Set<TEntity>().AsNoTracking().ToList();
        }
        public TEntity GetById(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }
        public List<TEntity> GetByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            return _db.Set<TEntity>().AsNoTracking().Where(predicate).ToList();
        }
        public void Insert(TEntity entities)
        {
            _db.Set<TEntity>().Add(entities);
            _db.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
            _db.SaveChanges();
        }
    }
}