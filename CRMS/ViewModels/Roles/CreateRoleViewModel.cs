using Microsoft.Build.Framework;

namespace CRMS.ViewModels.Role
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }

    }
}
