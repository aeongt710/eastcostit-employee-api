using DemoApi.IRepository;
using DemoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            var employees = await _employeeRepository.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>?> GetEmployeeById(int? id)
        {
            if(id == null)
            {
                return null;
            }
            var employee = await _employeeRepository.GetEmployeeById(id);

            if (employee == null)
            {
                return null;
            }

            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> SaveEmployee(Employee employee)
        {
            var createdEmployee = await _employeeRepository.SaveEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = createdEmployee.ID }, createdEmployee);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.ID)
            {
                return BadRequest();
            }

            var updatedEmployee = await _employeeRepository.UpdateEmployee(employee);

            if (updatedEmployee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(updatedEmployee);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteEmployee(int id)
        {
            try
            {
                var success = await _employeeRepository.DeleteEmployee(id);
                return Ok(success);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
