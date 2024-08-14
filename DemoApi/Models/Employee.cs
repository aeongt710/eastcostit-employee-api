using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

namespace DemoApi.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? EmployeeGenderId { get; set; }
        public Gender? EmployeeGender { get; set; }
        public int Salary { get; set; }
    }
}
