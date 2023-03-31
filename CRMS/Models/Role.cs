using Microsoft.Build.Framework;
using System.ComponentModel;

namespace CRMS.Models
{
    public class Role
    {
        public Guid RoleId { get; set; }
        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
        public ICollection<User>? Users { get; set; }

        public Role() { }

        public Role(Guid roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }
    }
}
