using Microsoft.AspNetCore.Identity;

namespace CRMS.Repository
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole<Guid>> GetRoles();
    }
}
