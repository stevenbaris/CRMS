using CRMS.Exceptions;
using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Models.Records;
using CRMS.Services;
using CRMS.Services.Contacts_Services;
using CRMS.Services.Records;
using CRMS.ViewModels.Records;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CRMS.Controllers
{
    public class EngagementController : Controller
    {
        private readonly IRepository<Engagement> _engagementRepo;
        private readonly IRepository<EngagementType> _eTypeRepo;
        private readonly IRepository<Effectivity> _effectivityRepo;
        private readonly IRepository<CommunicationMethod> _commsMethodRepo;
        private readonly IContactRepository _contactRepo;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public EngagementController(
            IRepository<Engagement> engagementRepo,
            IRepository<EngagementType> eTypeRepo,
            IRepository<Effectivity> effectivityRepo,
            IRepository<CommunicationMethod> commsMethodRepo,
            IContactRepository contactRepo,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _engagementRepo = engagementRepo;
            _eTypeRepo = eTypeRepo;
            _effectivityRepo = effectivityRepo;
            _commsMethodRepo = commsMethodRepo;
            _contactRepo = contactRepo;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var engagement = await _engagementRepo.GetAllAsync();
            return View(engagement);

        }

        public async Task<IActionResult> Details(Guid id)
        {
            var engagement = await _engagementRepo.GetbyIdAsync(id);
            if (engagement == null)
            {
                throw new RecordNotFoundException($"Engagement with id {id} not found.");
            }
            return View(engagement);
        }

        // GET: Engagement/Create
        public async Task<IActionResult> Create()
        {
            ViewData["EngagementTypeList"] = new SelectList(await _eTypeRepo.GetAllAsync(), "EType_Id", "EngagementName");
            ViewData["EffectivityList"] = new SelectList(await _effectivityRepo.GetAllAsync(), "Effectivity_Id", "Effectivity_Name");
            ViewData["CommsMethodList"] = new SelectList(await _commsMethodRepo.GetAllAsync(), "CommunicationMethod_Id", "CommunicationMethodName");
            ViewData["ContactsList"] = new SelectList(await _contactRepo.GetAllAsync(), "Contact_Id", "FullName");
            
            return View();
        }

        // POST: Engagement/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Engagement engagement)
        {
            if (ModelState.IsValid)
            {
                var user = await _signInManager.UserManager.GetUserAsync((ClaimsPrincipal)User);
                engagement.CreatedDate = DateTime.Now;
                engagement.CreatedById = user.Id;
                await _engagementRepo.CreateAsync(engagement);
                return RedirectToAction(nameof(Index));
            }
            return View(engagement);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await _engagementRepo.GetbyIdAsync(id);

            if (model == null)
            {
                return NotFound();
            }
           
            ViewData["EngagementTypeList"] = new SelectList(await _eTypeRepo.GetAllAsync(), "EType_Id", "EngagementName");
            ViewData["EffectivityList"] = new SelectList(await _effectivityRepo.GetAllAsync(), "Effectivity_Id", "Effectivity_Name");
            ViewData["CommsMethodList"] = new SelectList(await _commsMethodRepo.GetAllAsync(), "CommunicationMethod_Id", "CommunicationMethodName");
            ViewData["ContactsList"] = new SelectList(await _contactRepo.GetAllAsync(), "Contact_Id", "FullName");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Engagement engagement)
        {
            if (id != engagement.Engagement_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                try
                {
                    var entity = await _engagementRepo.GetbyIdAsync(id);

                    if (entity == null)
                    {
                        return NotFound();
                    }
                    await _engagementRepo.UpdateAsync(engagement);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw new Exception();
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["EngagementTypeList"] = new SelectList(await _eTypeRepo.GetAllAsync(), "EType_Id", "EngagementName");
            ViewData["EffectivityList"] = new SelectList(await _effectivityRepo.GetAllAsync(), "Effectivity_Id", "Effectivity_Name");
            ViewData["CommsMethodList"] = new SelectList(await _commsMethodRepo.GetAllAsync(), "CommunicationMethod_Id", "CommunicationMethodName");
            ViewData["ContactsList"] = new SelectList(await _contactRepo.GetAllAsync(), "Contact_Id", "FullName");
            return View(engagement);
        }

        public async Task<IActionResult> Remove(Guid id)
        {
            var contact = await _engagementRepo.GetbyIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            //ViewBag.ContactId = id;
            return View(contact);
        }

        
        [HttpPost]
        public async Task<IActionResult> RemoveConfirmed(Guid id)
        {
            if (_engagementRepo == null)
            {
                return Problem("Entity set 'CRMSDbContext'  is null.");
            }
            var engagement = await _engagementRepo.GetbyIdAsync(id);
            if (engagement != null)
            {
                await _engagementRepo.DeleteAsync(id);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
