using CRMS.Models;

namespace CRMS.Services.Contacts_Services
{
    public interface IContactRepository : IRepository<Contacts>
    {
        //ADMIN
        Task<List<Contacts>> GetContactsWithOwnerAsync();
        Task<List<Contacts>> GetContactsWithoutOwnerAsync();

        //USER
        Task<List<Contacts>> GetAllMyContactsAsync(Guid userGuid);
        Task<List<Contacts>> GetMyCreatedContactsAsync(Guid userGuid);
        Task<List<Contacts>> GetMyAssignedContactsAsync(Guid userGuid);
        Task<bool> EmailExistsAsync(string email, Guid? contactId = null);

    }
}
