using CRMS.Models;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CRMS.ViewComponents.Contacts
{
    public class _AllContactsViewComponent : ViewComponent
    {
        private readonly IContactRepository _contactRepo;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public _AllContactsViewComponent(
            IContactRepository contactRepo,
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _contactRepo = contactRepo;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.IsInRole("Admin"))
            {
                IndexViewModel model = new IndexViewModel
                {
                    AllContacts = _contactRepo.GetAllAsync().Result
                };
                return View(model);
            }
            else
            {
                var user = await _signInManager.UserManager.GetUserAsync((ClaimsPrincipal)User);
                var userId = user.Id;

                IndexViewModel model = new IndexViewModel
                {
                    AllContacts = _contactRepo.GetAllMyContactsAsync(userId).Result
                };
                return View(model);

            }

            throw new InvalidOperationException("Unexpected code path reached.");
        }
    }
}
