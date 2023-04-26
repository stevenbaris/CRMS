using CRMS.Models.Customization;

namespace CRMS.ViewModels.Customization
{
    public class IndexViewModel
    {
        public List<AppointmentPurpose> Purposes { get; set; }
        public List<CommunicationMethod> CommunicationMethods { get; set; }
        public List<Effectivity> Effectivity { get; set; }
        public List<EngagementType> EngagementTypes { get; set; }
        public List<LeadStatus> LeadStatus { get; set; }
        public List<Source> sources { get; set; }
    }
}
