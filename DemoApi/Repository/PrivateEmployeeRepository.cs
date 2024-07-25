using DemoApi.IRepository;
using Dapper;
using DemoApi.Data;
using DemoApi.Models;
using Microsoft.Data.SqlClient;
using System.Data;
namespace DemoApi.Repository
{
    public class PrivateEmployeeRepository: IPrivateEmployeeRepository
    {
        private readonly DatabaseConnection _conn;
        private readonly string tenantId;
        public PrivateEmployeeRepository(DatabaseConnection conn)
        {
            _conn = conn;
        }

        public List<Employee> GetAllEmployees()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var model = sqlcon.Query<Employee>("SELECT * From Employees", null, null, true, 0, commandType: CommandType.Text).ToList();
                return model;
            }
        }
    }
}
