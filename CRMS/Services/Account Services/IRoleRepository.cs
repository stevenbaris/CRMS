using Microsoft.AspNetCore.Identity;

namespace CRMS.Services.Account_Services
{
    public interface IRoleService : IRepository<IdentityRole<Guid>>
    {
        ICollection<IdentityRole<Guid>> GetAllRolesAsync();
    }
}
