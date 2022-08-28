using application_behavioural_management.Models;
using Microsoft.EntityFrameworkCore;

namespace application_behavioural_management.Data
{
    public class BehaviourContext:DbContext
    {
        public BehaviourContext(DbContextOptions<BehaviourContext> options) : base(options)
        {

        }
        public DbSet<SecurityPolicySetupMaster> SecurityPolicySetupMasters { get; set; }
    }
}
