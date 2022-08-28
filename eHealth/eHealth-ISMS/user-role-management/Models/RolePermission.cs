using System.ComponentModel.DataAnnotations;

namespace user_role_management.Models
{
    public class RolePermission
    {
        [Key]
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizedDate { get; set; }
    }
}
