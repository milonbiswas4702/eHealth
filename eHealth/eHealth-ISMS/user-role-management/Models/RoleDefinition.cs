using System.ComponentModel.DataAnnotations;

namespace user_role_management.Models
{
    public class RoleDefinition
    {
        [Key]
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public string PageId { get; set; }
        public string CreatePermission { get; set; }
        public string ViewPermission { get; set; }
        public string UpdatePermission { get; set; }
        public string DeletePermission { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizedDate { get; set; }
    }
}
