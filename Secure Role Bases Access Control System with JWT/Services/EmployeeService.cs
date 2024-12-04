using Secure_Role_Bases_Access_Control_System_with_JWT.Context;
using Secure_Role_Bases_Access_Control_System_with_JWT.Interfaces;
using Secure_Role_Bases_Access_Control_System_with_JWT.Models;

namespace Secure_Role_Bases_Access_Control_System_with_JWT.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _context;
        public EmployeeService(JwtContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            var emp = _context.Employees.Add(employee);
            _context.SaveChanges();
            return emp.Entity;
        }

        public List<Employee> GetEmployeeDetails()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
    }
}
