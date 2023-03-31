using CRMS.Models;

namespace CRMS.Repository
{
    public interface IRolesRepository
    {
        Task<List<Role>> GetRoles();
        Task<Role?> GetRoletById(Guid RoleId);
        Task<Role?> AddRole(Role Roles);
        Task<Role?> UpdateRole(Guid RoleId, Role Roles);
        Task<Role?> DeleteRole(Guid RoleId);
    }
}
