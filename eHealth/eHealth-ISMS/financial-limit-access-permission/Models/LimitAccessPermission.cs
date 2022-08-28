using System.ComponentModel.DataAnnotations;

namespace financial_limit_access_permission.Models
{
    public class LimitAccessPermission
    {
        [Key]
        public string LimitId { get; set; }
        public string UserId { get; set; }
        public string EmployeeId { get; set; }
        public string PageId { get; set; }
        public string MaxTransactionLimit { get; set; }
        public string MaxTransactionAuthorizationLimit { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string LastEditedBy { get; set; }
        public string LastEditedDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizedDate { get; set; }
    }
}
