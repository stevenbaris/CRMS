using CRMS.Models;
using CRMS.Models.Records;

namespace CRMS.ViewModels.Dashboard
{
    public class DashboardViewModel
    {
        public List<Contacts>? Contacts { get; set; }
        public List<Leads>? Leads { get; set; }
        public List<Engagement>? Engagement { get; set; }
        public List<Appointments>? Appointments { get; set; }

    }
}
