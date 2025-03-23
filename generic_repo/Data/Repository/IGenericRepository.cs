
using System.Linq.Expressions;

namespace generic_repo.Data
{
    public interface IGenericRepository<T> where T : class
    {
        public IEnumerable<T> GetAll(int pageNumber, int pageSize);
        public T GetById(int id);
        public List<T> GetByCondition(Expression<Func<T, bool>> predicate);
        public void Insert(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}