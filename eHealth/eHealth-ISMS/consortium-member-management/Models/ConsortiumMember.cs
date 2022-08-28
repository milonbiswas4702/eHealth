using System.ComponentModel.DataAnnotations;

namespace consortium_member_management.Models
{
    public class ConsortiumMember
    {
        [Key]
        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberInformation { get; set; }
        public string ControllingAuthority { get; set; }
        public string IsTrusted { get; set; }
        public string IsActive { get; set; }
        public string IsLoggedIn { get; set; }
        public string SessionId { get; set; }
        public string SessionData { get; set; }
        public string LoginLocation { get; set; }
        public string DeviceLocation { get; set; }
        public string MacAddress { get; set; }
        public string UsingBrowser { get; set; }
        public string IPAddress { get; set; }
        public string LastLoginTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string LastEditedBy { get; set; }
        public string LastEditedDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizedDate { get; set; }
    }
}
