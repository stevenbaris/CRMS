using CRMS.Models;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace CRMS.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactRepository _contactRepository;
        private readonly IContactRepository _users;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ContactsController(
            IContactRepository contactRepository,
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _contactRepository = contactRepository;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new IndexViewModel();

            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                    // Get all contacts for admin
                    model.AllContacts = await _contactRepository.GetAllAsync();
                    model.AssignedContacts = await _contactRepository.GetContactsWithOwnerAsync();
                    model.UnassignedContacts = await _contactRepository.GetContactsWithoutOwnerAsync();
                }
                else
                {
                    // Get all contacts for non-admin user
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    model.AllContacts = await _contactRepository.GetAllMyContactsAsync(Guid.Parse(userId));
                    model.MyContacts = await _contactRepository.GetMyCreatedContactsAsync(Guid.Parse(userId));
                    model.AssignedContacts = await _contactRepository.GetMyAssignedContactsAsync(Guid.Parse(userId));
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return PartialView("_CreateModal.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Contacts contact)
        {
            if (ModelState.IsValid)
            {
                var todo = _contactRepository.CreateAsync(contact);
                return RedirectToAction("Index");
            }
            return PartialView("_CreateModal.cshtml", contact);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid contactGuid)
        {
            var contact = await _contactRepository.GetbyIdAsync(contactGuid);
            return PartialView("_EditModal.cshtml", contact);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Contacts contact)
        {
            var con = await _contactRepository.UpdateAsync(contact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid guid)
        {
            var contact = await _contactRepository.GetbyIdAsync(guid);
            return PartialView("_DeleteModal", contact);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(Guid guid)
        {
            var contact = await _contactRepository.GetbyIdAsync(guid);
            if (contact != null)
            {
                await _contactRepository.DeleteAsync(guid);
            }
            return RedirectToAction("Index");
        }











        [HttpGet]
        public async Task<IActionResult> Index1()
        {
            //If Signed-IN
            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                    //Go to AllContacts
                    return RedirectToAction("AllContacts");
                }
                else
                {
                    // Go to AllMyContacts
                    return RedirectToAction("AllMyContacts");
                }
            }
            //If NOT Signed-IN
            return RedirectToAction("Login", "User");
        }

        [HttpGet]
        public async Task<IActionResult> AllContacts()
        {
            var model= await _contactRepository.GetAllAsync();
            return PartialView("GetAll/_AllContacts.cshtml", model);
        }

        public async Task<IActionResult> AllMyContacts(Guid userGuid)
        {
            var model = await _contactRepository.GetAllMyContactsAsync(userGuid);
            return PartialView("GetAll/_AllContacts.cshtml", model);
        }
    }
}
