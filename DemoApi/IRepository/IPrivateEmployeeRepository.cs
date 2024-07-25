using DemoApi.Models;

namespace DemoApi.IRepository
{
    public interface IPrivateEmployeeRepository
    {
        public List<Employee> GetAllEmployees();
    }
}
