using CRMS.Models.Customization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CRMS.Models.Records
{
    public class Engagement
    {

        public Guid Engagement_Id { get; set; } = Guid.NewGuid();

        [Required]
        [DisplayName("Engagement Date")]
        [DataType(DataType.Date)]
        //[Range(typeof(DateTime), null, DateTime.Now.ToString("yyyy-MM-dd"), ErrorMessage = "Date must not be in the future.")]
        public DateTime Engagement_Date { get; set; }


        [Required]
        [DisplayName("Topic")]
        public string Topic { get; set; }


        [Required]
        [DisplayName("Description")]
        [MaxLength(500)]
        public string? Engagement_Description { get; set; } = String.Empty;


        [Required]
        [DisplayName("Date Created")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        [Required]
        [DisplayName("Created By")]
        public Guid CreatedById { get; set; }


        [Required]
        [DisplayName("Engagement Type")]
        public Guid ETypeId { get; set; }


        [Required]
        [DisplayName("Effectivity")]
        public Guid EffectivityId { get; set; }


        [Required]
        [DisplayName("Communications Method")]
        public Guid CommsMethodId { get; set; }


        [Required]
        [DisplayName("For Contact")]
        public Guid ContactId { get; set; }



        public ApplicationUser? User { get; set;}
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
