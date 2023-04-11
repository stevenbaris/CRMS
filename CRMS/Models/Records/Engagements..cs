using CRMS.Models.Customization;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace CRMS.Models.Records
{
    public class Engagement
    {

        public Guid Engagement_Id { get; set; }

        [Required]
        //[Range(typeof(DateTime), null, DateTime.Now.ToString("yyyy-MM-dd"), ErrorMessage = "Date must not be in the future.")]
        public DateTime Engagement_Date { get; set; }


        [Required]
        public string Topic { get;}


        [Required]       
        public string? Engagement_Description { get;} = String.Empty;


        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        [Required]
        public Guid CreatedById { get; set; }


        [Required]
        public Guid ETypeId { get; set; }


        [Required]
        public Guid EffectivityId { get; set; }


        [Required]
        public Guid CommsMethodId { get; set; }


        [Required]
        public Guid ContactId { get; set; }



        public ApplicationUser? user { get; set;}
        public EngagementType? EngagementType { get; set; }
        public Effectivity? Effectivity { get; set; }
        public CommunicationMethod? CommunicationMethod { get; set; }
        public Contacts? Contacts { get; set; }


        public Engagement() { }

        public Engagement(Guid engagement_Id, DateTime engagement_Date, string topic, string? engagement_Description, DateTime createdDate, Guid createdById, Guid eTypeId, Guid effectivityId, Guid commsMethodId, Guid contactId)
        {
            Engagement_Id = engagement_Id;
            Engagement_Date = engagement_Date;
            Topic = topic;
            Engagement_Description = engagement_Description;
            CreatedDate = createdDate;
            CreatedById = createdById;
            ETypeId = eTypeId;
            EffectivityId = effectivityId;
            CommsMethodId = commsMethodId;
            ContactId = contactId;
        }
    }

}
