using CRMS.Models;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Contacts
{
    public class DeleteContactViewComponent:ViewComponent
    {
        private readonly IContactRepository _contactsRepo;
        private readonly UserManager<ApplicationUser> _userManager;

        public DeleteContactViewComponent(
            UserManager<ApplicationUser> userManager,
            IContactRepository contactsRepo)
        {
            _userManager = userManager;
            _contactsRepo = contactsRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = User.Identity?.Name;
            if (!Guid.TryParse(userId, out Guid userIdGuid))
            {
                userIdGuid = Guid.Empty;
            }

            IndexViewModel model = new IndexViewModel
            {
                Contacts = await _contactsRepo.GetbyIdAsync(userIdGuid)
            };
            return View(model);
        }

    }
}
