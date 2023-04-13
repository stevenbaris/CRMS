using CRMS.Models;


namespace CRMS.Services
{
    public interface IUserRepository
    {
        ICollection<ApplicationUser> GetUsers();

        ApplicationUser GetUser(Guid id);
        ApplicationUser AddUser(ApplicationUser user);

        ApplicationUser UpdateUser(ApplicationUser user);
    }
}
