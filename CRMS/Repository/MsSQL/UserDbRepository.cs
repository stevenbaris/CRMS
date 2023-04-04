using CRMS.Data;
using CRMS.Models;

namespace CRMS.Repository.MsSQL
{
    public class UserDBRepository : IUserRepository
    {
        private readonly CRMSDbContext _context;

        public UserDBRepository(CRMSDbContext context)
        {
            _context = context;
        }

        public ICollection<ApplicationUser> GetUsers()
        {
            return _context.Users.ToList();
        }

        public ApplicationUser GetUser(Guid id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public ApplicationUser UpdateUser(ApplicationUser user)
        {
            _context.Update(user);
            _context.SaveChanges();

            return user;
        }

        public ApplicationUser AddUser(ApplicationUser user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
