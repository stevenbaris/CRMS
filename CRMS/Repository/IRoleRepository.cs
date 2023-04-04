using Microsoft.AspNetCore.Identity;

namespace CRMS.Repository
{
    public interface IRoleRepository
    {
        List<IdentityRole<Guid>> GetRoles();
    }
}
