using CRMS.Models.Records;
using Microsoft.EntityFrameworkCore;
using CRMS.Data;

namespace CRMS.Services.Records
{
    public class LeadsRepo : IRepository<Leads>
    {
        private readonly CRMSDbContext _dBcontext;
        public LeadsRepo(CRMSDbContext dBcontext)  
        {
            _dBcontext = dBcontext;
        }

        public async Task<Leads> CreateAsync(Leads entity)
        {
            _dBcontext.Leads.Add(entity);
            await _dBcontext.SaveChangesAsync();
            return entity;
        }

        public async Task<Leads> DeleteAsync(Guid id)
        {
            var src = await GetbyIdAsync(id);
            if (src != null)
            {
                _dBcontext.Leads.Remove(src);
                await _dBcontext.SaveChangesAsync();
            }
            return src;
        }

        public async Task<List<Leads>> GetAllAsync()
        {
            return await _dBcontext.Leads.ToListAsync();
        }

        public async Task<Leads> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.Leads.FindAsync(id);
        }

        public async Task<Leads> UpdateAsync(Leads entity)
        {
            _dBcontext.Leads.Update(entity);
            await _dBcontext.SaveChangesAsync();
            return entity;
        }
    }
}
