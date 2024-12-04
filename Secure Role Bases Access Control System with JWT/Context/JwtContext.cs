using Microsoft.EntityFrameworkCore;
using Secure_Role_Bases_Access_Control_System_with_JWT.Models;

namespace Secure_Role_Bases_Access_Control_System_with_JWT.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options) 
        {
        
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

    }
}
