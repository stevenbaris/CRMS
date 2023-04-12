using CRMS.Models;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Contacts
{
    public class _AssignedContactsViewComponent:ViewComponent
    {
        private readonly IContactRepository _contactRepo;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public _AssignedContactsViewComponent(SignInManager<ApplicationUser> signInManager, IContactRepository contactRepo)
        {
            _signInManager = signInManager;
            _contactRepo = contactRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.IsInRole("Admin"))
            {
                var model = _contactRepo.GetContactsWithOwnerAsync().Result;
                return View(model);
            }
            else
            {
                var userId = User.Identity?.Name;
                if (!Guid.TryParse(userId, out Guid userIdGuid))
                {
                    userIdGuid = Guid.Empty;
                }

                var model = _contactRepo.GetMyAssignedContactsAsync(userIdGuid).Result;
                return View(model);

            }

            throw new InvalidOperationException("Unexpected code path reached.");
        }

    }
}
