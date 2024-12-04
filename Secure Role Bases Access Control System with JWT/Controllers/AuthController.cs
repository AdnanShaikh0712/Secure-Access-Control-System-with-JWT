using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Secure_Role_Bases_Access_Control_System_with_JWT.Interfaces;
using Secure_Role_Bases_Access_Control_System_with_JWT.Models;
using LoginRequest = Secure_Role_Bases_Access_Control_System_with_JWT.Models.LoginRequest;



namespace Secure_Role_Bases_Access_Control_System_with_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;
        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

   
        [HttpPost("login")]
        public string Login([FromBody] LoginRequest obj) 
        {
            var token = _auth.Login(obj);
            return token;
        }
      

        [HttpPost("assignRole")]
        public bool AssignRoleToUser([FromBody] AddUserRole userRole)
        {
            var addedUserRole = _auth.AssignRoleToUser(userRole);
            return addedUserRole;
        }

   
        [HttpPost("addUser")]
        public User AddUser([FromBody] User user)
        {
           var addeduser =  _auth.AddUser(user);
            return addeduser;
        }

        [HttpPost("addRole")]
        public Role AddRole([FromBody] Role role)
        {
            var addedRole = _auth.AddRole(role);
            return addedRole;
        }

     
    }
}
