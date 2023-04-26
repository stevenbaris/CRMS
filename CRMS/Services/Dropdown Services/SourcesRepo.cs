using CRMS.Data;
using CRMS.Models.Customization;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.SqlRepositories
{
    public class SourcesRepo : IRepository<Source>
    {
        private readonly CRMSDbContext _dBcontext;

        public SourcesRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<Source> CreateAsync(Source src)
        {
            _dBcontext.Sources.Add(src);
            await _dBcontext.SaveChangesAsync();
            return src;
        }

        public async Task<Source> DeleteAsync(Guid id)
        {
            var src = await GetbyIdAsync(id);
            if (src != null)
            {
                _dBcontext.Sources.Remove(src);
                await _dBcontext.SaveChangesAsync();
            }
            return src;
        }

        public async Task<List<Source>> GetAllAsync()
        {
            return await _dBcontext.Sources.ToListAsync();
        }

        public async Task<Source> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.Sources.FindAsync(id);
        }

        public async Task<Source> UpdateAsync(Source src)
        {
            _dBcontext.Sources.Update(src);
            await _dBcontext.SaveChangesAsync();
            return src;
        }
    }
}
