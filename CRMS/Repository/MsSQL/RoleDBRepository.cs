using CRMS.Data;
using Microsoft.AspNetCore.Identity;

namespace CRMS.Repository
{
    public class RoleDBRepository : IRoleRepository
    {
        private readonly CRMSDbContext _context;

        public RoleDBRepository(CRMSDbContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
