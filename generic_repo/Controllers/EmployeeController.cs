using generic_repo.Data;
using generic_repo.Data.DTO;
using generic_repo.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeService _service;
        public EmployeeController(EmployeeService service)
        {
            this._service = service;
        }
        [HttpGet]
        [Route("get/all")]
        public IEnumerable<Employee> GetAll()
        {
            return this._service.GetAll(1, 1);
        }

        [HttpGet]
        [Route("get/{id}")]
        public Employee GetById(int id)
        {
            return this._service.GetById(id);
        }


        [HttpGet]
        [Route("GetByEmail")]
        public List<Employee> GetByeemail([FromQuery] string email)
        {
            return this._service.GetByEmail(email);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            this._service.Insert(employee);
            return Ok(new
            {
                Message = "Insert complete!"
            });
        }

        [HttpPut]
        public IActionResult Put([FromBody] Employee employee)
        {
            this._service.Update(employee);
            return Ok(new
            {
                Message = "Update complete!"
            });
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Employee employee)
        {
            this._service.Delete(employee);
            return Ok(new
            {
                Message = "Delete complete!"
            });
        }
    }
}
