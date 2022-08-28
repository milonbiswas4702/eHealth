using feature_access_permission.Model;
using Microsoft.EntityFrameworkCore;

namespace feature_access_permission.Data
{
    public class AccessPermissionContext: DbContext
    {
        public AccessPermissionContext (DbContextOptions<AccessPermissionContext> options) : base(options) {
        
        }
        public DbSet<PageDefination> PageDefinations { get; set; }
        public DbSet<AccessPermission> AccessPermissions { get; set; }
    }
}
