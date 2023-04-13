using CRMS.Models;
using Microsoft.AspNetCore.Identity;

namespace CRMS.ViewModels.User
{
    public class IndexUserViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Role { get; set; }
        public List<ApplicationUser> applicationUsers { get; set; }
        public IEnumerable<IdentityRole<Guid>>? Roles { get; set; }

    }
}
