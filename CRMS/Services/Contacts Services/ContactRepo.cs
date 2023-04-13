using CRMS.Data;
using CRMS.Exceptions;
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
            try
            {
                _dBcontext.Contacts.Add(contact);
                await _dBcontext.SaveChangesAsync();
                return contact;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while creating contact.", ex);
            }
        }

        //DELETE
        public async Task<Contacts> DeleteAsync(Guid id)
        {
            try
            {
                var contact = await GetbyIdAsync(id);
                if (contact != null)
                {
                    _dBcontext.Contacts.Remove(contact);
                    await _dBcontext.SaveChangesAsync();
                }
                else
                {
                    throw new EntityNotFoundException("Contact not found.");
                }
                return contact;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while deleting contact.", ex);
            }
        }

        //UPDATE
        public async Task<Contacts> UpdateAsync(Contacts contact)
        {
            try
            {
                _dBcontext.Contacts.Update(contact);
                await _dBcontext.SaveChangesAsync();
                return contact;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while updating contact.", ex);
            }
        }


        //GET ONE BY ID
        public async Task<Contacts> GetbyIdAsync(Guid id)
        {
            try
            {
                var contact = await _dBcontext.Contacts
                    .AsNoTracking()
                    .Include(c => c.Owner)
                    .Include(c => c.Creator)
                    .SingleOrDefaultAsync(c => c.Contact_Id == id);
                if (contact == null)
                {
                    throw new EntityNotFoundException("Contact not found.");
                }
                return contact;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while retrieving contact by id.", ex);
            }
        }

        //ADMIN - GET ALL
        public async Task<List<Contacts>> GetAllAsync()
        {
            try
            {
                return await _dBcontext.Contacts
                     .AsNoTracking()
                     .Include(c => c.Creator)
                     .Include(c => c.Owner)
                     .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while retrieving all contacts.", ex);
            }
        }

        //ADMIN - WITH OWNERS
        public async Task<List<Contacts>> GetContactsWithOwnerAsync()
        {
            try
            {
                return await _dBcontext.Contacts
                   .Include(c => c.Creator)
                   .Include(c => c.Owner)
                   .Where(c => c.ContactOwnerID != null)
                   .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while retrieving contacts with owner.", ex);
            }
        }

        //ADMIN - WITHOUT OWNERS
        public async Task<List<Contacts>> GetContactsWithoutOwnerAsync()
        {
            try
            {
                return await _dBcontext.Contacts
                    .Include(c => c.Creator)
                    .Include(c => c.Owner)
                   .Where(c => c.ContactOwnerID == null)
                   .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while retrieving contacts without owner.", ex);
            }
        }

        //USER - GET ALL USER'S CONTACTS
        public async Task<List<Contacts>> GetAllMyContactsAsync(Guid userGuid)
        {
            try
            {
                return await _dBcontext.Contacts
                    .Include(c => c.Creator)
                    .Include(c => c.Owner)
                    .Where(c => c.ContactCreatorID == userGuid || (c.ContactOwnerID == userGuid && c.ContactCreatorID != userGuid))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ContactException($"Error retrieving contacts for user with ID {userGuid}.", ex);
            }
        }

        //USER - GET USER'S CREATED CONTACT
        public async Task<List<Contacts>> GetMyCreatedContactsAsync(Guid userGuid)
        {
            try
            {
                return await _dBcontext.Contacts
                    .Include(c => c.Creator)
                    .Include(c => c.Owner)
                    .Where(c => c.ContactCreatorID == userGuid)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ContactException($"Error retrieving created contacts for user with ID {userGuid}.", ex);
            }
        }

        //USER - GET CONTACTS ASSIGNED TO THE USER
        public async Task<List<Contacts>> GetMyAssignedContactsAsync(Guid userGuid)
        {
            try
            {
                return await _dBcontext.Contacts
                    .Include(c => c.Creator)
                    .Include(c => c.Owner)
                    .Where(c => c.ContactOwnerID == userGuid && c.ContactCreatorID != userGuid)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ContactException($"Error retrieving assigned contacts for user with ID {userGuid}.", ex);
            }
        }




    }
}
