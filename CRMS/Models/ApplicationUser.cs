using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRMS.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [DisplayName("First Name")]
        [MinLength(2, ErrorMessage =
            "The first name is too short")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [MinLength(2, ErrorMessage =
            "The first name is too short")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required]
        public DateTime DOB { get; set; }
        [MinLength(5, ErrorMessage =
            "The Address is too short")]
        [Required]
        public string Address { get; set; }
    }
}
