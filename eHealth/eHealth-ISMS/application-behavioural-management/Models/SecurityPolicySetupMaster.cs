using System.ComponentModel.DataAnnotations;

namespace application_behavioural_management.Models
{
    public class SecurityPolicySetupMaster
    {
        [Key]
        public string License { get; set; }
        public string OfficeId { get; set; }
        public string NumberOfStuffs { get; set; }
        public string NumberOfDoctors { get; set; }
        public string NumberOfResearchScientists { get; set; }
        public string NumberOfIndoorPatients { get; set; }
        public string NumberOfOutdoorPatients { get; set; }
        public string NumberOfOtherUser { get; set; }
        public string NumberOfThirdPartyUser { get; set; }
        public string IsConsortiumActive { get; set; }
        public string IsSystemActive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string LastEditedBy { get; set; }
        public string LastEditedDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizedDate { get; set; }
    }
}
