using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using unit_of_work.Data;
using unit_of_work.Model;

namespace unit_of_work.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private  IGenericRepo<Employee> _employeeRepo;
    private IGenericRepo<Department> _departmentRepo;
    private IUnitOfWork _uow;
    public EmployeeController(IGenericRepo<Employee> employeeRepo, IGenericRepo<Department> departmentRepo)
    {
        _employeeRepo = employeeRepo;
        _departmentRepo = departmentRepo;
    }
    public EmployeeController(IUnitOfWork uow)
    {
        _uow = uow; 
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
        await _uow.BeginTransationAsync();
        await _uow.employeeRepo.InsertAsync(emp);
        if(await _uow.CommitAsync())
        {
            return Ok();
        }
        else
        {
            return StatusCode(500);
        }

    }

    [HttpPut(Name = "PUT")]
    public async Task<IActionResult> Update(UpdateEmployeeDTO employee)
    {
        Employee emp = new Employee{
            Id = employee.Id,
            EmployeeName = employee.EmployeeName,
            DepartmentId = employee.DepartmentId
        };

        await _uow.BeginTransationAsync();
        await _uow.employeeRepo.UpdateAsync(emp);
        if(await _uow.CommitAsync())
        {
            return Ok();
        }
        else
        {
            return StatusCode(500);
        }
    }

    [HttpDelete(Name = "DELETE")]
    public async Task<IActionResult> Delete(DeleteEmployeeDTO employee)
    {
        Employee emp = new Employee{
            Id = employee.Id
        };
        await _uow.BeginTransationAsync();
        await _uow.employeeRepo.DeleteAsync(emp);
        if(await _uow.CommitAsync())
        {
            return Ok();
        }
        else
        {
            return StatusCode(500);
        }
    }    
}
