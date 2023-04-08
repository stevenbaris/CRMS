using CRMS.Data;
using CRMS.Models;
using CRMS.Services.Contacts_Services;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.SqlRepositories
{
    public class ContactRepo : IContactRepository
    {
        private readonly CRMSDbContext _dBcontext;

        public ContactRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        //CREATE
        public async Task<Contacts> CreateAsync(Contacts contact)
        {
            _dBcontext.Contacts.Add(contact);   
            await _dBcontext.SaveChangesAsync();
            return contact;
        }

        //DELETE
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

        //UPDATE
        public async Task<Contacts> UpdateAsync(Contacts contact)
        {
            _dBcontext.Contacts.Update(contact);
            await _dBcontext.SaveChangesAsync();
            return contact;
        }
        
        
        //GET ONE BY ID
        public async Task<Contacts> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.Contacts
                .Include(c => c.Owner)
                .Include(c => c.Creator)
                .SingleOrDefaultAsync(c => c.Contact_Id == id);
        }

        //ADMIN - GET ALL
        public async Task<List<Contacts>> GetAllAsync()
        {
           return await _dBcontext.Contacts
                .Include(c=> c.Creator) 
                .Include(c=> c.Owner)
                .ToListAsync();
        }

        //ADMIN - WITH OWNERS
        public async Task<List<Contacts>> GetContactsWithOwnerAsync()
        {
            return await  _dBcontext.Contacts
               .Where(c => c.ContactOwnerID != null)
               .ToListAsync();
        }

        //ADMIN - WITHOUT OWNERS
        public async Task<List<Contacts>> GetContactsWithoutOwnerAsync()
        {
            return await _dBcontext.Contacts
               .Where(c => c.ContactOwnerID == null)
               .ToListAsync();
        }

        //USER - GET ALL USER'S CONTACTS
        public async Task<List<Contacts>> GetAllMyContactsAsync(Guid userGuid)
        {
            return await _dBcontext.Contacts
                .Where(c => c.ContactCreatorID == userGuid || (c.ContactOwnerID == userGuid && c.ContactCreatorID != userGuid))
                .ToListAsync();
        }

        //USER - GET USER'S CREATED CONTACT
        public async Task<List<Contacts>> GetMyCreatedContactsAsync(Guid userGuid)
        {
            return await _dBcontext.Contacts
                .Include(c => c.Creator)
                .Where(c => c.ContactCreatorID == userGuid)
                .ToListAsync();
        }

        //USER - GET CONTACTS ASSIGNED TO THE USER
        public async Task<List<Contacts>> GetMyAssignedContactsAsync(Guid userGuid)
        {
            return await _dBcontext.Contacts
               .Where(c => c.ContactOwnerID == userGuid && c.ContactCreatorID != userGuid)
               .ToListAsync();
        }

      


    }
}
