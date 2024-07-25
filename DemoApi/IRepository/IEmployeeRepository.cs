using DemoApi.Models;

namespace DemoApi.IRepository
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetAllEmployees();
        public Task<Employee?> GetEmployeeById(int? empId);
        public Task<Employee> SaveEmployee(Employee emp);
        public Task<Employee> UpdateEmployee(Employee emp);
        public Task<bool> DeleteEmployee(int empId);
    }
}
