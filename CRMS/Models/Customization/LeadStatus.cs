using Microsoft.Build.Framework;
using System.ComponentModel;

namespace CRMS.Models.Customization
{
    public class LeadStatus
    {
        public Guid LeadStatus_Id { get; set; } = Guid.Empty;

        [Required]
        [DisplayName("Lead Status: ")]
        public string LeadStatusName { get; set; } = string.Empty;
        public LeadStatus() { }

        public LeadStatus(Guid leadStatus_Id, string leadStatusName)
        {
            LeadStatus_Id = leadStatus_Id;
            LeadStatusName = leadStatusName;
        }
    }
}
