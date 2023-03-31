using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models
{
    public class AppointmentPurpose
    {
        public Guid Purpose_Id { get; set; } = Guid.Empty;
        
        [Required]
        [DisplayName("Purpose: ")]
        public string PurposeName { get; set;} = string.Empty;

        public AppointmentPurpose() { }

        public AppointmentPurpose(Guid purpose_Id, string purposeName)
        {
            Purpose_Id = purpose_Id;
            PurposeName = purposeName;
        }
    }
}
