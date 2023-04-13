using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Models.Records;

namespace CRMS.ViewModels.Records
{
    public class EngagementViewModel
    {
        public Engagement? Engagement { get; set; }
        public List<EngagementType>? EngagementTypes { get; set; }
        public List<Effectivity>? Effectivities { get; set; }
        public List<CommunicationMethod>? CommunicationMethods { get; set; }
        public List<Contacts>? Contacts { get; set; }
        public List<ApplicationUser>? Users { get; set; }   


    }
}
