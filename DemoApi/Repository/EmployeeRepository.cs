using DemoApi.Data;
using DemoApi.IRepository;
using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DemoDbContext _context;

        public EmployeeRepository(DemoDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteEmployee(int empId)
        {
            var employee = await _context.Employees.FindAsync(empId);
            if (employee == null)
            {
                throw new KeyNotFoundException("Employee not found");
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetEmployeeById(int? empId)
        {
            return await _context.Employees.Where(x => x.ID == empId).FirstOrDefaultAsync();
        }

        public async Task<Employee> SaveEmployee(Employee emp)
        {
            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();

            return emp;
        }

        public async Task<Employee> UpdateEmployee(Employee emp)
        {
            var existingEmployee = await _context.Employees.FindAsync(emp.ID);
            if (existingEmployee == null)
            {
                throw new KeyNotFoundException("Employee not found");
            }

            existingEmployee.FirstName = emp.FirstName;
            existingEmployee.LastName = emp.LastName;
            existingEmployee.Gender = emp.Gender;
            existingEmployee.Salary = emp.Salary;

            _context.Employees.Update(existingEmployee);
            await _context.SaveChangesAsync();

            return existingEmployee;
        }
    }
}