using CRMS.Models;

namespace CRMS.Repository
{
    public interface IUserRepository
    {
        ICollection<ApplicationUser> GetUsers();

        ApplicationUser GetUser(Guid id);
        ApplicationUser AddUser(ApplicationUser user);

        ApplicationUser UpdateUser(ApplicationUser user);
    }
}
