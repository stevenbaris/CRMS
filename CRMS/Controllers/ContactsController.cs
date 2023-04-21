using CRMS.Models;
using CRMS.Models.Records;
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
        private readonly IRepository<Leads> _leadsRepo;
        private readonly IRepository<Engagement> _engagementsRepo;
        private readonly IRepository<Appointments> _appointmentsRepo;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ContactsController(
            IContactRepository contactRepository,
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            IUserRepository userRepository,
            IRepository<Leads> leadsRepo,
            IRepository<Engagement> engagementsRepo,
            IRepository<Appointments> appointmentsRepo)
        {
            _contactRepository = contactRepository;
            _signInManager = signInManager;
            _userManager = userManager;
            _userRepository = userRepository;
            _leadsRepo = leadsRepo;
            _engagementsRepo = engagementsRepo;
            _appointmentsRepo = appointmentsRepo;
        }


        [HttpGet]
        public async Task<IActionResult> ViewAll()
        {

            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                    return View(await _contactRepository.GetAllAsync());
                }
                else
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    return View(await _contactRepository.GetAllMyContactsAsync(Guid.Parse(userId)));
                }
            }
            return RedirectToAction("Login","User");

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
                ContactCreatorID = userId,
                UpdateDate = DateTime.Now,
                UpdatedBy = userId,
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
            //ViewData["OwnerList"] = creatorList;
            ViewData["CurrentUser"] = new SelectList(currentUser, "Value", "Text", contact.Owner);

            return View(contact);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Contacts contact)
        {
            var user = await _signInManager.UserManager.GetUserAsync((ClaimsPrincipal)User);
            var userId = user.Id;
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
            var currentUser = users.Where(u => u.Id == userId).Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.FullName
            });
            ViewData["CreatorList"] = new SelectList(creatorList, "Value", "Text", contact.Creator);
            ViewData["OwnerList"] = new SelectList(creatorList, "Value", "Text", contact.Owner);
            ViewData["CurrentUser"] = new SelectList(currentUser, "Value", "Text", contact.Owner);
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

                    var user = await _signInManager.UserManager.GetUserAsync((ClaimsPrincipal)User);
                    model.UpdateDate = DateTime.Now;
                    model.Updater = user;
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
            if (_contactRepository == null)
            {
                return Problem("Entity set 'CRMSDbContext'  is null.");
            }

            var contact = await _contactRepository.GetbyIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            
            await _contactRepository.DeleteAsync(id);
            return RedirectToAction(nameof(ViewAll));
        }

        
        //[HttpPost]
        //public async Task<IActionResult> RemoveConfirmed(Guid id)
        //{
        //    if (_contactRepository == null)
        //    {
        //        return Problem("Entity set 'CRMSDbContext'  is null.");
        //    }
        //    var contact = await _contactRepository.GetbyIdAsync(id);
        //    if (contact != null)
        //    {
        //        await _contactRepository.DeleteAsync(id);
        //    }


        //    return RedirectToAction(nameof(ViewAll));
        //}


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
                ListLeads = (await _leadsRepo.GetAllAsync())
                    .Where(l => l.ProspectId == contact.Contact_Id)
                    .ToList(),
                ListAppointments = (await _appointmentsRepo.GetAllAsync())
                    .Where(a => a.ContactId == contact.Contact_Id)
                    .ToList(),
                ListEngagement = (await _engagementsRepo.GetAllAsync())
                    .Where(e => e.ContactId == contact.Contact_Id)
                    .ToList()

            };

            if (model == null)
            {
                return NotFound();
            }

            var nameParts = contact.FullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstNameInitial = nameParts[0].Substring(0, 1);
            var lastNameInitial = nameParts[nameParts.Length - 1].Substring(0, 1);

            // Combine the initials into a single string
            var initials = $"{firstNameInitial}{lastNameInitial}".ToUpper();

            // Set the initials as a ViewData property
            ViewData["ContactInitials"] = initials;


            return View(model);
        }

    }
}
