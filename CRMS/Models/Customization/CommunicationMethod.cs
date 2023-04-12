using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models.Customization
{
    public class CommunicationMethod
    {
        public Guid CommunicationMethod_Id { get; set; } = Guid.Empty;

        [Required]
        [DisplayName("Communication Method: ")]
        public string CommunicationMethodName { get; set; } = string.Empty;

        public CommunicationMethod() { }

        public CommunicationMethod(Guid communicationMethod_Id, string communicationMethodName)
        {
            CommunicationMethod_Id = communicationMethod_Id;
            CommunicationMethodName = communicationMethodName;
        }
    }
}
