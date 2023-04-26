using CRMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel;

namespace CRMS.ViewModels.Role
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }

        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
        public List<ApplicationUser> usersWithRole { get; set; }
        public IdentityRole<Guid> Roles { get; set; }

    }
}
