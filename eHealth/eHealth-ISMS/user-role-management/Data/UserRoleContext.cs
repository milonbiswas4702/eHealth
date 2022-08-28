using Microsoft.EntityFrameworkCore;
using user_role_management.Models;

namespace user_role_management.Data
{
    public class UserRoleContext: DbContext
    {
        public UserRoleContext(DbContextOptions<UserRoleContext> options) : base(options)
        {

        }
        public DbSet<RoleDefinition> RoleDefinitions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
    }
}
