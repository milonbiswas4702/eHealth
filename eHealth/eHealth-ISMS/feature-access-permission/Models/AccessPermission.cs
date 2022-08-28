using System.ComponentModel.DataAnnotations;

namespace feature_access_permission.Model
{
    public class AccessPermission
    {
        [Key]
        public string UserId { get; set; }
        public string UserWebId { get; set; }
        public string ViewPermission { get; set; }
        public string CreatePermission { get; set; }
        public string EditPermission { get; set; }
        public string DeletePermission { get; set; }
        public string PageId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizedDate { get; set; }
    }
}
