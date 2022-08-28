using Microsoft.EntityFrameworkCore;
using user_information_management.Models;

namespace user_information_management.Data
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> LoginUsers { get; set; }
    }
}
