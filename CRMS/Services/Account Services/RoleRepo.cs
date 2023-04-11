using CRMS.Data;
using CRMS.Models;
using Microsoft.AspNetCore.Identity;

namespace CRMS.Services.Account_Services
{
    public class RoleRepo : IRoleService
    {
        private readonly CRMSDbContext _dBcontext;
        private readonly RoleManager<ApplicationUser> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleRepo(
            CRMSDbContext dBcontext,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationUser> roleManager)
        {
            _dBcontext = dBcontext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityRole<Guid>> CreateAsync(IdentityRole<Guid> _role)
        {
            //IdentityResult result = await _roleManager.CreateAsync(_role);
            //return result;
            throw new NotImplementedException();
        }

        public Task<IdentityRole<Guid>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityRole<Guid>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<IdentityRole<Guid>> GetAllRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityRole<Guid>> GetbyIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityRole<Guid>> UpdateAsync(IdentityRole<Guid> entity)
        {
            throw new NotImplementedException();
        }
    }
}
