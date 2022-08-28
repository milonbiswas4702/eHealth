using financial_limit_access_permission.Models;
using Microsoft.EntityFrameworkCore;

namespace financial_limit_access_permission.Data
{
    public class LimitAccessContext:DbContext
    {
        public LimitAccessContext(DbContextOptions<LimitAccessContext> options) : base(options)
        {

        }
        public DbSet<LimitAccessPermission> LimitAccessPermissions { get; set; }
    }
}
