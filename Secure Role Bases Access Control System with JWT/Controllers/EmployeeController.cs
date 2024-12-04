using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Secure_Role_Bases_Access_Control_System_with_JWT.Interfaces;
using Secure_Role_Bases_Access_Control_System_with_JWT.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Secure_Role_Bases_Access_Control_System_with_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EmployeeController : ControllerBase
    {   
        private readonly IEmployeeService _employeeService;
        // GET: api/<EmployeeController>

        public EmployeeController(IEmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Authorize(Roles ="User,Admin")]
        public List<Employee> GetEmployees()
        {
            return _employeeService.GetEmployeeDetails();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public Employee AddEmployee([FromBody] Employee emp)
        {
            var employee = _employeeService.AddEmployee(emp);
            return employee;
        }
    }
}
