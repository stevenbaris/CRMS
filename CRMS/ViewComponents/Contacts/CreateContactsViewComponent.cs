using CRMS.Models;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Web.Mvc;

namespace CRMS.ViewComponents.Contacts
{
    public class CreateContactsViewComponent : ViewComponent
    {
        private readonly IContactRepository _contactsRepo;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public CreateContactsViewComponent(
            IContactRepository contactsRepo,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _contactsRepo = contactsRepo;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _signInManager.UserManager.GetUserAsync((ClaimsPrincipal)User);
            var userId = user.Id;

            var cont = new CRMS.Models.Contacts
            {
                CreateDate = DateTime.Now,
                ContactCreatorID = userId
            };
            IndexViewModel model = new IndexViewModel
            {
                Contacts = cont,
                AppUsers = await _userManager.Users.ToListAsync(),
            };
            //ViewData["UserList"] = new SelectList(_userManager.Users.ToList(), "Id", "FirstName"+" "+"LastName"); ;
            return View(model);
        }
    }
}
