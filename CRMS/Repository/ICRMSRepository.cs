using CRMS.Models;

namespace CRMS.Repository
{
    public interface ICRMSRepository
    {
        List<User> GetAllUsers();

        User GetUserById(Guid Id);
 
        User AddUser(User newUser);
 
        User UpdateUser(Guid userId, User newUser);

        User DeleteUser(Guid userId);
    }
}
