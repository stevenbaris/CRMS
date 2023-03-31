using CRMS.Data;
using CRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.SqlRepositories
{
    public class CommunicationMethodRepo : IRepository<CommunicationMethod>
    {
        private readonly CRMSDbContext _dBcontext;

        public CommunicationMethodRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<CommunicationMethod> CreateAsync(CommunicationMethod method)
        {
            _dBcontext.CommunicationMethods.Add(method);
            await _dBcontext.SaveChangesAsync();
            return method;
        }

        public async Task<CommunicationMethod> DeleteAsync(Guid id)
        {
           var method = await GetbyIdAsync(id);
            if (method != null)
            {
                _dBcontext.CommunicationMethods.Remove(method);
                await _dBcontext.SaveChangesAsync();
            }
            return method;
        }

        public async Task<List<CommunicationMethod>> GetAllAsync()
        {
            return await _dBcontext.CommunicationMethods.ToListAsync();
        }

        public async Task<CommunicationMethod> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.CommunicationMethods.FindAsync(id);
        }

        public async Task<CommunicationMethod> UpdateAsync(CommunicationMethod method)
        {
            _dBcontext.CommunicationMethods.Update(method);
            await _dBcontext.SaveChangesAsync();
            return method;
        }
    }
}
