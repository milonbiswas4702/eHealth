using consortium_member_management.Models;
using Microsoft.EntityFrameworkCore;

namespace consortium_member_management.Data
{
    public class ConsortiumMemberContext:DbContext
    {
        public ConsortiumMemberContext(DbContextOptions<ConsortiumMemberContext> options) : base(options)
        {

        }
        public DbSet<ConsortiumMember> ConsortiumMembers { get; set; }
    }
}
