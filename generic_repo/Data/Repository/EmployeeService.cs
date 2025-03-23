using System.Linq.Expressions;
using generic_repo.Data.Model;

namespace generic_repo.Data;

public class EmployeeService
{
    private IGenericRepository<Employee> _repo;
    public EmployeeService(IGenericRepository<Employee> service)
    {
        this._repo = service;
    }

    public IEnumerable<Employee> GetAll(int pageNumber, int pageSize)
        {
            return this._repo.GetAll(pageNumber, pageSize);
        }
        public Employee GetById(int id)
        {
            return this._repo.GetById(id);
        }
        public List<Employee> GetByEmail(string email)
        {
            return this._repo.GetByCondition(e => e.Email == email);
        }
        public void Insert(Employee entities)
        {
            this._repo.Insert(entities);
        }
        public void Update(Employee entity)
        {
            this._repo.Update(entity);
        }
        public void Delete(Employee entity)
        {
            this._repo.Delete(entity);
        }
}