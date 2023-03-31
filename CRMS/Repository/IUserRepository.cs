using CRMS.Models;

namespace CRMS.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User?> GetUserById(Guid? userId);
        Task<User?> AddUser(User newUser);
        Task<User?> UpdateUser(Guid userId, User newUser);
        Task<User?> DeleteUser(Guid userId);
        Task<List<Role>> FetchRoleList();

    }
}
