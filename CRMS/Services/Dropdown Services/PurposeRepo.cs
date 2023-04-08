using CRMS.Data;
using CRMS.Models.Customization;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace CRMS.Services.SqlRepositories
{
    public class PurposeRepo : IRepository<AppointmentPurpose>
    {
        private readonly CRMSDbContext _dBcontext;

        public PurposeRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }



        public async Task<AppointmentPurpose> CreateAsync(AppointmentPurpose purpose)
        {
            _dBcontext.Purposes.Add(purpose);
            await _dBcontext.SaveChangesAsync();

            return purpose;
        }

        public async Task<AppointmentPurpose> DeleteAsync(Guid id)
        {
            var oldPurpose = await GetbyIdAsync(id);
            if (oldPurpose != null)
            {
                _dBcontext.Purposes.Remove(oldPurpose);
                await _dBcontext.SaveChangesAsync();
            }
            return oldPurpose;
        }

        public async Task<List<AppointmentPurpose>> GetAllAsync()
        {
            return await _dBcontext.Purposes.ToListAsync();
        }

        public async Task<AppointmentPurpose> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.Purposes.FindAsync(id);
        }

        public async Task<AppointmentPurpose> UpdateAsync(AppointmentPurpose purpose)
        {
            _dBcontext.Purposes.Update(purpose);
            await _dBcontext.SaveChangesAsync();
            return purpose;
        }
    }
}
