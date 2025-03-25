using Microsoft.EntityFrameworkCore;
using unit_of_work.Model;

namespace unit_of_work.Data;

public class EmployeeRepo : IGenericRepo<Employee>
{
    private IGenericRepo<Employee> _genericRepo;
    public EmployeeRepo(IGenericRepo<Employee> genericRepo)
    {
        _genericRepo = genericRepo;
    }
    public async Task<List<Employee>> GetAllAsync(int pageIndex, int pageSize)
    {
        return await _genericRepo.GetAllAsync(pageIndex, pageSize);
    }
    public async Task<Employee> GetAsync(int id)
    {
        return await _genericRepo.GetAsync(id);
    }
    public async ValueTask<Employee> InsertAsync(Employee entity)
    {
        return await _genericRepo.InsertAsync(entity);
    }
    public async Task<int> UpdateAsync(Employee entity)
    {
        return await _genericRepo.UpdateAsync(entity);
    }
    public async Task<int> DeleteAsync(Employee entity)
    {
        return await _genericRepo.DeleteAsync(entity);
    }
}