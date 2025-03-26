using unit_of_work.Model;

namespace unit_of_work.Data;

public interface IUnitOfWork
{
    IGenericRepo<Employee> employeeRepo {get;}
    IGenericRepo<Department> departmentRepo {get;}

    public Task BeginTransationAsync();
    public Task<bool> CommitAsync();
}