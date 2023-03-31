using Microsoft.EntityFrameworkCore;
using CRMS.Data;
using CRMS.Models;
using CRMS.Services;

namespace CRMS.Repository.MsSQL
{
    public class RolesDbRepository : IRepository<Role>
    {
        public Task<Role> CreateAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<Role> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Role>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetbyIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Role> UpdateAsync(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
