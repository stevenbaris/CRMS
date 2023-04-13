using CRMS.Data;
using CRMS.Models.Records;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.Record_Services
{
    public class AppointmentsRepo : IRepository<Appointments>
    {
        private readonly CRMSDbContext _dBcontext;

        public AppointmentsRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<Appointments> CreateAsync(Appointments entity)
        {
            _dBcontext.Appointments.Add(entity);
            await _dBcontext.SaveChangesAsync();
            return entity;
        }

        public async Task<Appointments> DeleteAsync(Guid id)
        {
            var src = await GetbyIdAsync(id);
            if (src != null)
            {
                _dBcontext.Appointments.Remove(src);
                await _dBcontext.SaveChangesAsync();
            }
            return src;
        }

        public async Task<List<Appointments>> GetAllAsync()
        {
            return await _dBcontext.Appointments.ToListAsync();
        }

        public async Task<Appointments> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.Appointments.FindAsync(id);
        }

        public async Task<Appointments> UpdateAsync(Appointments entity)
        {
            _dBcontext.Appointments.Update(entity);
            await _dBcontext.SaveChangesAsync();
            return entity;
        }
    }
}
