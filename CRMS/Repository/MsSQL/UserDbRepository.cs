using CRMS.Data;
using CRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Repository.MsSQL
{
    public class UserDbRepository : ICRMSRepository
    {
        CRMSDbContext _dbContext;

        public UserDbRepository(CRMSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User AddUser(User newUser)
        {
            _dbContext.Add(newUser);
            // CUD operation you need to save the details -> Commit
            _dbContext.SaveChanges();
            return newUser;
        }

        public User DeleteUser(Guid userId)
        {
            var user = GetUserById(userId);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
            return user;
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.AsNoTracking().ToList();
        }

        public User GetUserById(Guid Id)
        {
            return _dbContext.Users.AsNoTracking().ToList().FirstOrDefault(t => t.UserId == Id);
        }

        public User UpdateUser(Guid userId, User newUser)
        {
            _dbContext.Users.Update(newUser);
            _dbContext.SaveChanges();
            return newUser;
        }
    }
}
