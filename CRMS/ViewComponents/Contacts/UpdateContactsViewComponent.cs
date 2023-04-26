using CRMS.Models;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

namespace CRMS.ViewComponents.Contacts
{
    public class UpdateContactsViewComponent:ViewComponent
    {
        private readonly IContactRepository _contactsRepo;
        private readonly UserManager<ApplicationUser> _userManager;

        public UpdateContactsViewComponent(
            UserManager<ApplicationUser> userManager, 
            IContactRepository contactsRepo)
        {
            _userManager = userManager;
            _contactsRepo = contactsRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync(Guid contactid)
        {

            IndexViewModel model = new IndexViewModel
            {
                Contacts = await _contactsRepo.GetbyIdAsync(contactid),
                AppUsers = await _userManager.Users.ToListAsync(),
            };
            //var model = await _contactsRepo.GetbyIdAsync(userId);
            //ViewData["UserList"] = new SelectList(_userManager.Users.ToList(), "Id", "FirstName" + " " + "LastName"); ;

            return View(model);
        }
    }
}
