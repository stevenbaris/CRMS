using CRMS.Data;
using CRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.SqlRepositories
{
    public class LeadStatusRepo : IRepository<LeadStatus>
    {
        private readonly CRMSDbContext _dBcontext;

        public LeadStatusRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<LeadStatus> CreateAsync(LeadStatus status)
        {
            _dBcontext.Statuses.Add(status);
            await _dBcontext.SaveChangesAsync();
            return status;

        }

        public async Task<LeadStatus> DeleteAsync(Guid id)
        {
            var status = await GetbyIdAsync(id);
            if (status != null) 
            {
                _dBcontext.Statuses.Remove(status);
                await _dBcontext.SaveChangesAsync();
            }
            return status;
        }

        public async Task<List<LeadStatus>> GetAllAsync()
        {
            return await _dBcontext.Statuses.ToListAsync();
        }

        public async Task<LeadStatus> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.Statuses.FindAsync(id);
        }

        public async Task<LeadStatus> UpdateAsync(LeadStatus status)
        {
            _dBcontext.Statuses.Update(status);
            await _dBcontext.SaveChangesAsync();
            return status;
        }
    }
}
