using Microsoft.AspNetCore.Identity.Data;
using Secure_Role_Bases_Access_Control_System_with_JWT.Models;

namespace Secure_Role_Bases_Access_Control_System_with_JWT.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public Employee AddEmployee(Employee employee);
    }
}
