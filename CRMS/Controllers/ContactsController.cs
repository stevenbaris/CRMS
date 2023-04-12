using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Repository;
using CRMS.Services.Contacts_Services;
using CRMS.ViewComponents.Contacts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CRMS.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUserRepository _userRepository;
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
                    model.AppUsers = await _userManager.Users.ToListAsync();
                }
                else
                {
                    // Get all contacts for non-admin user
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    model.AllContacts = await _contactRepository.GetAllMyContactsAsync(Guid.Parse(userId));
                    model.MyContacts = await _contactRepository.GetMyCreatedContactsAsync(Guid.Parse(userId));
                    model.AssignedContacts = await _contactRepository.GetMyAssignedContactsAsync(Guid.Parse(userId));
                    model.AppUsers = await _userManager.Users.ToListAsync();
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var contact = await _contactRepository.GetbyIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var userId = User.Identity?.Name;
            Guid.TryParse(userId, out Guid userIdGuid);

            var contact = new Contacts
            {
                ContactCreatorID = userIdGuid,
                CreateDate = DateTime.Now,
            };

            var appUsers = await _userManager.Users.ToListAsync();

            IndexViewModel model = new IndexViewModel
            {
                Contacts = contact,
                AppUsers = appUsers
            };

            return View("Index", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(IndexViewModel iviewmodel)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.CreateAsync(iviewmodel.Contacts);
                return RedirectToAction("Index");
            }
            //return ViewComponent("CreateContacts", iviewmodel);
            return PartialView("~/Views/Contacts/_CreateModal.cshtml", iviewmodel);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var contact = await _contactRepository.GetbyIdAsync(id);
            if (contact != null) { 

                IndexViewModel model = new IndexViewModel
                {
                    Contacts = contact,
                    AppUsers = await _userManager.Users.ToListAsync()
                
                };

                if (model == null)
                {
                    return NotFound();
                }
                //return ViewComponent("UpdateContacts", contactGuid);
                return PartialView("~/Views/Contacts/_EditModal.cshtml", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Update(Guid id,IndexViewModel iviewModel)
        {
            if (id != iviewModel.Contacts.Contact_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _contactRepository.UpdateAsync(iviewModel.Contacts);

                }
                catch (DbUpdateConcurrencyException)
                {
                    throw new Exception();
                }
                return RedirectToAction(nameof(Index));
            }
            return PartialView("~/Views/Contacts/_EditModal.cshtml", iviewModel);
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









        //[HttpGet]
        //public async Task<IActionResult> Index1()
        //{
        //    //If Signed-IN
        //    if (_signInManager.IsSignedIn(User))
        //    {
        //        if (User.IsInRole("Admin"))
        //        {
        //            //Go to AllContacts
        //            return RedirectToAction("AllContacts");
        //        }
        //        else
        //        {
        //            // Go to AllMyContacts
        //            return RedirectToAction("AllMyContacts");
        //        }
        //    }
        //    //If NOT Signed-IN
        //    return RedirectToAction("Login", "User");
        //}

        //[HttpGet]
        //public async Task<IActionResult> AllContacts()
        //{
        //    var model= await _contactRepository.GetAllAsync();
        //    return PartialView("~/Views/Contacts/GetAll/_AllContacts.cshtml", model);
        //}

        //public async Task<IActionResult> AllMyContacts(Guid userGuid)
        //{
        //    var model = await _contactRepository.GetAllMyContactsAsync(userGuid);
        //    return PartialView("~/Views/Contacts/GetAll/_AllContacts.cshtml", model);
        //}
    }
}
