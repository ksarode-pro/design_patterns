using Microsoft.EntityFrameworkCore;
using unit_of_work.Model;

namespace unit_of_work.Data;

public class DepartmentRepo : IGenericRepo<Department>
{
    private IGenericRepo<Department> _genericRepo;
    public DepartmentRepo(IGenericRepo<Department> genericRepo)
    {
        _genericRepo = genericRepo;
    }
    public async Task<List<Department>> GetAllAsync(int pageIndex, int pageSize)
    {
        return await _genericRepo.GetAllAsync(pageIndex, pageSize);
    }
    public async Task<Department> GetAsync(int id)
    {
        return await _genericRepo.GetAsync(id);
    }
    public async Task InsertAsync(Department entity)
    {
        await _genericRepo.InsertAsync(entity);
        // return await _genericRepo.InsertAsync(entity);
    }
    public async Task UpdateAsync(Department entity)
    {
        await _genericRepo.UpdateAsync(entity);
        // return await _genericRepo.UpdateAsync(entity);
    }
    public async Task DeleteAsync(Department entity)
    {
        await _genericRepo.DeleteAsync(entity);
        // return await _genericRepo.DeleteAsync(entity);
    }
}