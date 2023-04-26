using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace CRMS.ViewModels.User
{
    public class LoginUserViewModel
    {
        [Required]
        [EmailAddress]
        [DisplayName("Username")]
        public string UserName { get; set; } = default!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; } = default!;

        public LoginUserViewModel() { }
    }
}
