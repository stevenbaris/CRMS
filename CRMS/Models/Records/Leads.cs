using CRMS.Models.Customization;
using CRMS.Services.Records;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models.Records
{
    public class Leads
    {
        public Guid Leads_Id { get; set; } = Guid.NewGuid();

        [Required]
        public DateTime Leads_DateTime { get; set; }

        public string? PrefContactMethod { get; set; } = String.Empty;

        public string? PrefContactDay { get; set; } = String.Empty;

        public string? PrefContactTime { get; set; } = String.Empty;
        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public Guid ProspectId { get; set; }

        [Required]
        public Guid StatusId { get; set; }
        [Required]
        public Guid LeadSourceId { get; set; }
        [Required]
        public Guid CreatedBy { get; set; }

        public Contacts? prospect { get; set; }
        public LeadStatus? status { get; set; }
        public Source? source { get; set; }
        public ApplicationUser? User { get; set; }

        public Leads() { }

        public Leads(Guid leads_Id, DateTime leads_DateTime, string? prefContactMethod, string? prefContactDay, string? prefContactTime, Guid prospectId, Guid statusId, Guid leadSourceId, Guid createdBy)
        {
            Leads_Id = leads_Id;
            Leads_DateTime = leads_DateTime;
            PrefContactMethod = prefContactMethod;
            PrefContactDay = prefContactDay;
            PrefContactTime = prefContactTime;
            ProspectId = prospectId;
            StatusId = statusId;
            LeadSourceId = leadSourceId;
            CreatedBy = createdBy;
        }
    }
}
