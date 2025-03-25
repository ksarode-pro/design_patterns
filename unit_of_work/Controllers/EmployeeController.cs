using Microsoft.AspNetCore.Mvc;
using unit_of_work.Data;
using unit_of_work.Model;

namespace unit_of_work.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private  IGenericRepo<Employee> _employeeRepo;
    public EmployeeController(IGenericRepo<Employee> employeeRepo)
    {
        _employeeRepo = employeeRepo;
    }

    [HttpGet(Name = "GetAll")]
    [Route("GetAll")]
    public async Task<IActionResult> GetAllAsync([FromHeader] int pageIndex, [FromHeader] int pageSize)
    {
        var employees = await _employeeRepo.GetAllAsync(pageIndex, pageSize);
        return Ok(employees);
    }

    [HttpGet(Name = "Get")]
    [Route("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var employee = await _employeeRepo.GetAsync(id);
        return Ok(employee);
    }

    [HttpPost(Name = "POST")]
    public async Task<IActionResult> Insert(NewEmployeeDTO employee)
    {
        Employee emp = new Employee{
            EmployeeName = employee.EmployeeName,
            DepartmentId = employee.DepartmentId
        };
        var result = await _employeeRepo.InsertAsync(emp);
        return Ok(result);
    }

    [HttpPut(Name = "PUT")]
    public async Task<IActionResult> Update(UpdateEmployeeDTO employee)
    {
        Employee emp = new Employee{
            Id = employee.Id,
            EmployeeName = employee.EmployeeName,
            DepartmentId = employee.DepartmentId
        };
        var result = await _employeeRepo.UpdateAsync(emp);
        return Ok(result);
    }

    [HttpDelete(Name = "DELETE")]
    public async Task<IActionResult> Delete(DeleteEmployeeDTO employee)
    {
        Employee emp = new Employee{
            Id = employee.Id
        };
        var result = await _employeeRepo.DeleteAsync(emp);
        return Ok(result);
    }    
}
