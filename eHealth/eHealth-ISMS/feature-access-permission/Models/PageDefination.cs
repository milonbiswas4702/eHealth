using System.ComponentModel.DataAnnotations;

namespace feature_access_permission.Model
{
    public class PageDefination
    {
        [Key]
        public string PageId { get; set; }
        public string PageName { get; set; }
        public string FunctionId { get; set; }
        public string ModuleId { get; set; }
        public string SystemId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizedDate { get; set; }
    }
}
