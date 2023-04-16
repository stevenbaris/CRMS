using CRMS.Models.Customization;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace CRMS.Models.Records
{
    public class Appointments
    {
        public Guid Appointment_Id { get; set; } = Guid.NewGuid();

        [Required]
        public DateTime Appointment_DateTime { get; set; }

        [Required]
        [MinLength(10, ErrorMessage ="Description must be at least 10 characters long.")]
        public string Description { get; set; } = String.Empty;

        [Required]
        public SchedStatus SchedStatus { get; set; }

        [Required]
        public Guid PurposeId { get; set; }

        [Required]
        public Guid ContactId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]  
        public Guid CreatedBy { get; set;}


        public Contacts? prospect { get; set; }
        public AppointmentPurpose? AppointmentPurpose { get; set; }
        public ApplicationUser? User { get; set; }


        public Appointments() { }

        public Appointments(Guid appointment_Id, DateTime appointment_DateTime, string description, SchedStatus schedStatus, Guid purposeId, Guid contactId, DateTime createdDate, Guid createdBy)
        {
            Appointment_Id = appointment_Id;
            Appointment_DateTime = appointment_DateTime;
            Description = description;
            SchedStatus = schedStatus;
            PurposeId = purposeId;
            ContactId = contactId;
            CreatedDate = createdDate;
            CreatedBy = createdBy;
        }
    }

    public enum SchedStatus
    {
        Upcoming,
        MetInPerson,
        MetOnline,
        Cancelled,
        NoShow,

    }

}
