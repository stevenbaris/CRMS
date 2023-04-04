using CRMS.Data;
using CRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.SqlRepositories
{
    public class CustomerRepo : IRepository<Contacts>
    {
        private readonly CRMSDbContext _dBcontext;

        public CustomerRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<Contacts> CreateAsync(Contacts contact)
        {
            _dBcontext.Contacts.Add(contact);   
            await _dBcontext.SaveChangesAsync();
            return contact;
        }

        public async Task<Contacts> DeleteAsync(Guid id)
        {
            var contact = await GetbyIdAsync(id);
            if (contact != null)
            {
                _dBcontext.Contacts.Remove(contact);
                await _dBcontext.SaveChangesAsync();
            }
            return contact;
        }

        public async Task<List<Contacts>> GetAllAsync()
        {
           return await _dBcontext.Contacts.ToListAsync();
        }

        public async Task<Contacts> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.Contacts.FindAsync(id);
        }

        public async Task<Contacts> UpdateAsync(Contacts contact)
        {
            _dBcontext.Contacts.Update(contact);
            await _dBcontext.SaveChangesAsync();
            return contact;
        }
    }
}
