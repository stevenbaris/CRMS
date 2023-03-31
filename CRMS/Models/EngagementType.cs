using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models
{
    public class EngagementType
    {
        public Guid EType_Id { get; set; } = Guid.Empty;

        [Required]
        [DisplayName("Engagement Type: ")]
        public string EngagementName { get; set; } = string.Empty;

        public EngagementType() { }

        public EngagementType(Guid eTypeId, string engagementName)
        {
            EType_Id = eTypeId;
            EngagementName = engagementName;
        }
    }
}
