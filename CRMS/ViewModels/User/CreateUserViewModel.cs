using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace CRMS.ViewModels.User
{
    public class CreateUserViewModel
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = default!;

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = default!;

        [Required]
        [MinLength(5, ErrorMessage = "The Address is too short")]
        public string Address { get; set; } = default!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = default!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare(nameof(Password), ErrorMessage = "Password and confirm password do not match.")]
        public string ConfirmPassword { get; set; } = default!;

        [Display(Name = "Role")]
        public string RoleName { get; set; }

     

    }
}
