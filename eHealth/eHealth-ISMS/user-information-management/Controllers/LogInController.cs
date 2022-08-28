using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using user_information_management.Data;
using user_information_management.Models;

namespace user_information_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly UserContext _context;
        public LogInController(UserContext context)
        {
            _context = context;
        }
        [HttpPost]
        public string Login([FromBody] Login user)
        {
            var loguser =_context.LoginUsers.SingleOrDefault(c => c.UserName == user.UserName);
            if (loguser.Password == user.Password)
            {
                return user.UserName + "can login";
            }
            return user.UserName + "can not login";
        }
    }
}
