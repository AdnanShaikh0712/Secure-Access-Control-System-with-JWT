namespace Secure_Role_Bases_Access_Control_System_with_JWT.Models
{
    public class AddUserRole
    {
        public int UserId { get; set; }
        public List<int> RoleIds { get; set; } 
    }
}
