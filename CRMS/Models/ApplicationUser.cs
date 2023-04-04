using Microsoft.AspNetCore.Identity;

namespace CRMS.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        
































        public ICollection<Contacts>? Contacts { get; set; }


    }
}
