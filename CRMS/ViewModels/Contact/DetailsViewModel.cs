using CRMS.Models;
using CRMS.Models.Records;

namespace CRMS.ViewModels.Contact
{
    public class DetailsViewModel
    {
        public Contacts? Contacts { get; set; }
        public Leads? Leads { get; set; }
        public Engagement? Engagement { get; set; }
        public Appointments? Appointments { get; set; }
        public List<Leads>? ListLeads { get; set; }
        public List<Engagement>? ListEngagement { get; set; }
        public List<Appointments>? ListAppointments { get;set; }

    }
}
