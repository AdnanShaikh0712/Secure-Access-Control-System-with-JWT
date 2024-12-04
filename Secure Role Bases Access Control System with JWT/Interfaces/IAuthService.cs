using Secure_Role_Bases_Access_Control_System_with_JWT.Models;

namespace Secure_Role_Bases_Access_Control_System_with_JWT.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);
        Role AddRole(Role role);
        bool AssignRoleToUser(AddUserRole obj);
     
    }
}
