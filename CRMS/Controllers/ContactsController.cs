using CRMS.Models;
using CRMS.Services;
using CRMS.Services.Contacts_Services;
using CRMS.ViewModels.Contact;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            UserManager<ApplicationUser> userManager,
            IUserRepository userRepository)
        {
            _contactRepository = contactRepository;
            _signInManager = signInManager;
            _userManager = userManager;
            _userRepository = userRepository;
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
            if (contact != null)
            {

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
        public async Task<IActionResult> Update(Guid id, IndexViewModel iviewModel)
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






        [HttpGet]
        public async Task<IActionResult> ViewAll()
        {
            return View(await _contactRepository.GetAllAsync());

        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var user = await _signInManager.UserManager.GetUserAsync((ClaimsPrincipal)User);
            var userId = user.Id;

            var contact = new Contacts
            {
                Contact_Id = Guid.NewGuid(),
                CreateDate = DateTime.Now,
                ContactCreatorID = userId
            };
            var users = await _userManager.Users.ToListAsync();
            var creatorList = users.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.FirstName + " " + u.LastName
            });
            var currentUser = users.Where(u=>u.Id == userId).Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.FullName
            });
            ViewData["CreatorList"] = new SelectList(creatorList, "Value", "Text", contact.Creator);
            ViewData["OwnerList"] = new SelectList(creatorList, "Value", "Text", contact.Owner);
            ViewData["CurrentUser"] = new SelectList(currentUser, "Value", "Text", contact.Owner);

            return View(contact);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Contacts contact)
        {
            if (ModelState.IsValid)
            {
                await _contactRepository.CreateAsync(contact);
                return RedirectToAction(nameof(ViewAll));
            }
            var users = await _userManager.Users.ToListAsync();
            var creatorList = users.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.FirstName + " " + u.LastName
            });
            ViewData["CreatorList"] = new SelectList(creatorList, "Value", "Text", contact.Creator);
            ViewData["OwnerList"] = new SelectList(creatorList, "Value", "Text", contact.Owner);
            return View(contact);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            //IndexViewModel model = new IndexViewModel
            //{
            //    Contacts = await _contactRepository.GetbyIdAsync(id),
            //    AppUsers = await _userManager.Users.ToListAsync()
            //};
            var model = await _contactRepository.GetbyIdAsync(id);

            if (model == null)
            {
                return NotFound();
            }
            var users = await _userManager.Users.ToListAsync();
            var creatorList = users.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.FirstName + " " + u.LastName
            });
            ViewData["CreatorList"] = new SelectList(creatorList, "Value", "Text", model.Creator);
            ViewData["OwnerList"] = new SelectList(creatorList, "Value", "Text", model.Owner);
            return View(model);
        }

        // POST: Effectivities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Contacts model)
        {
            if (id != model.Contact_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                try
                {
                    var entity = await _contactRepository.GetbyIdAsync(model.Contact_Id);

                    if (entity == null)
                    {
                        return NotFound();
                    }
                    await _contactRepository.UpdateAsync(model);


                }
                catch (DbUpdateConcurrencyException)
                {
                    throw new Exception();
                }
                return RedirectToAction(nameof(ViewAll));
            }
            var users = await _userManager.Users.ToListAsync();
            var creatorList = users.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.FirstName + " " + u.LastName
            });
            ViewData["CreatorList"] = new SelectList(creatorList, "Value", "Text", model.Creator);
            ViewData["OwnerList"] = new SelectList(creatorList, "Value", "Text", model.Owner);
            return View(model);
        }

        public async Task<IActionResult> Remove(Guid id)
        {
            var contact = await _contactRepository.GetbyIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewBag.ContactId = id;
            return View(contact);
        }

        
        [HttpPost]
        public async Task<IActionResult> RemoveConfirmed(Guid id)
        {
            if (_contactRepository == null)
            {
                return Problem("Entity set 'CRMSDbContext'  is null.");
            }
            var contact = await _contactRepository.GetbyIdAsync(id);
            if (contact != null)
            {
                await _contactRepository.DeleteAsync(id);
            }


            return RedirectToAction(nameof(ViewAll));
        }


        public async Task<IActionResult> ContactDetail(Guid id)
        {
            var contact = await _contactRepository.GetbyIdAsync(id);
            
            if (contact == null)
            {
                return NotFound();
            }

            DetailsViewModel model = new DetailsViewModel
            {
                Contacts = contact,

            };

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

    }
}
