using System.ComponentModel.DataAnnotations;

namespace user_information_management.Models
{
    public class Login
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
