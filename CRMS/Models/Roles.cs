namespace CRMS.Models
{
    public class Roles
    {
        public Guid RolesId { get; set; }
        public string RoleName { get; set; }
        public ICollection<User>? Users { get; set; }

        public Roles() { }

        public Roles(Guid rolesId, string roleName)
        {
            RolesId = rolesId;
            RoleName = roleName;
        }
    }
}
