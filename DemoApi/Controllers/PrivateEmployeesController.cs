using DemoApi.IRepository;
using DemoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PrivateEmployeesController : ControllerBase
    {
        private readonly IPrivateEmployeeRepository _employeeRepository;

        public PrivateEmployeesController(IPrivateEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return Ok(employees);
        }
    }
}
