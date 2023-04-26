using Microsoft.AspNetCore.Identity;

namespace CRMS.Services
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole<Guid>> GetRoles();
    }
}
