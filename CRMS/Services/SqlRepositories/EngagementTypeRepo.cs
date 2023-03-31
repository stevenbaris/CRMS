using CRMS.Data;
using CRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.SqlRepositories
{
    public class EngagementTypeRepo : IRepository<EngagementType>
    {
        private readonly CRMSDbContext _dBcontext;

        public EngagementTypeRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<EngagementType> CreateAsync(EngagementType eType)
        {
            _dBcontext.EngagementTypes.Add(eType);
            await _dBcontext.SaveChangesAsync();
            return eType;
        }

        public async Task<EngagementType> DeleteAsync(Guid id)
        {
            var eType = await GetbyIdAsync(id);
            if (eType != null)
            {
                _dBcontext.EngagementTypes.Remove(eType);
                await _dBcontext.SaveChangesAsync();
            }
            return eType;
        }

        public async Task<List<EngagementType>> GetAllAsync()
        {
            return await _dBcontext.EngagementTypes.ToListAsync();
        }

        public async Task<EngagementType> GetbyIdAsync(Guid id)
        {
          
            return await _dBcontext.EngagementTypes.FindAsync(id);
        }

        public async Task<EngagementType> UpdateAsync(EngagementType eType)
        {
            _dBcontext.EngagementTypes.Update(eType);
            await _dBcontext.SaveChangesAsync();
            return eType;
        }
    }
}
