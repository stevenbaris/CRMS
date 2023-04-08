using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRMS.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [DisplayName("First Name")]
        [MinLength(2, ErrorMessage = "The first name is too short")]
        public string FirstName { get; set; }
        
        
        [Required]
        [DisplayName("Last Name")]
        [MinLength(2, ErrorMessage = "The last name is too short")]
        public string LastName { get; set; }


        [Required]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }
        
        
        [Required]
        [MinLength(5, ErrorMessage = "The Address is too short")]
        public string Address { get; set; }



        public ICollection<Contacts>? Contacts { get; set; }
    }
}
