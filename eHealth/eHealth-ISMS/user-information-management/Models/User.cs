using System.ComponentModel.DataAnnotations;

namespace user_information_management.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserSSN { get; set; }
        public string DateOfBirth { get; set; }
        public string IsEmployee { get; set; }
        public string EmployeeId { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizedDate { get; set; }
        public string LastEditedBy { get; set; }
        public string LastEditedDate { get; set; }
    }
}
