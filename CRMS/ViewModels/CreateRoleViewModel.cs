using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace CRMS.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }

    }
}
