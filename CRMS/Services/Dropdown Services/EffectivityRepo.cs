using CRMS.Data;
using CRMS.Models.Customization;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.SqlRepositories
{
    public class EffectivityRepo : IRepository<Effectivity>
    {
        private readonly CRMSDbContext _dBcontext;

        public EffectivityRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }


        public async Task<Effectivity> CreateAsync(Effectivity eff)
        {
            _dBcontext.Effectivity.Add(eff);
            await _dBcontext.SaveChangesAsync();
            return eff;
        }

        public async Task<Effectivity> DeleteAsync(Guid id)
        {
            var eff = await GetbyIdAsync(id);
            if (eff != null)
            {
                _dBcontext.Effectivity.Remove(eff);
                await _dBcontext.SaveChangesAsync();
            }
            return eff;
        }

        public async Task<List<Effectivity>> GetAllAsync()
        {
            return await _dBcontext.Effectivity.ToListAsync();
        }

        public async Task<Effectivity> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.Effectivity.FindAsync(id);
        }

        public async Task<Effectivity> UpdateAsync(Effectivity eff)
        {
            _dBcontext.Effectivity.Update(eff);
            await _dBcontext.SaveChangesAsync();
            return eff;
        }
    }
}
