using CRMS.Data;
using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Models.Records;
using CRMS.Services;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CRMS.Controllers
{
    public class LeadsController : Controller
    {
        private readonly IRepository<Leads> _leads;
        private readonly CRMSDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IContactRepository _contactRepo;

        public LeadsController(IRepository<Leads> leads, CRMSDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IContactRepository contactRepo)
        {
            _leads = leads;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _contactRepo = contactRepo;
        }

        public async Task<IActionResult> Index()
        {
            var leadsIndex = await _leads.GetAllAsync();
            if (TempData["SuccessMessage"] != null)
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }
            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"];
            }

            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                    return View("~/Views/Records/Leads/Index.cshtml", leadsIndex);
                }
                else
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var myLeads = leadsIndex.Where(l => l.CreatedBy == Guid.Parse(userId));
                    return View("~/Views/Records/Leads/Index.cshtml", myLeads);
                }
            }
          
            return RedirectToAction("Index", "Home");
           
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var leadsDetails = await _leads.GetbyIdAsync(id);
            if (leadsDetails == null)
            {
                return NotFound();
            }

            return View("~/Views/Customization/Components/Purpose/AppointmentPurposes/Details.cshtml", leadsDetails);
        }

        public async Task<IActionResult> Create(Guid? Id)
        {

            ViewData["ProductId"] = new SelectList(_context.Products, "Product_Id", "ProductName");
            ViewData["StatusId"] = new SelectList(_context.Statuses, "LeadStatus_Id", "LeadStatusName");
            //ViewData["LeadSourceId"]
                if (Id == null)
                {
               
                    ViewData["LeadSourceId"] = new SelectList(_context.Sources, "Source_Id", "SourceName");
                }
                else
                {
                    var contact = await _contactRepo.GetbyIdAsync(Id ?? Guid.Empty);
                    var contactCreator = contact.ContactCreatorID;
                    if (contactCreator == null)
                    {
                        var items = _context.Sources
                       .Where(s => s.SourceName == "Company-Generated")
                       .Select(s => new SelectListItem { Text = s.SourceName, Value = s.Source_Id.ToString() })
                       .ToList();
                        ViewData["LeadSourceId"] = new SelectList(items, "Value", "Text");
                    }
                    else
                    {
                        ViewData["LeadSourceId"] = new SelectList(_context.Sources, "Source_Id", "SourceName");
                    }

                   
                }
            
            //ViewData["ProspectId"]
                if (_signInManager.IsSignedIn(User))
                {

                    if (User.IsInRole("Admin"))
                    {

                        if (Id != null)
                        {
                            var contactId = Id ?? Guid.Empty; ;
                            var contact = await _contactRepo.GetbyIdAsync(contactId);
                            ViewData["ProspectId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName", contact.Contact_Id);
                        }
                        else
                        {
                            ViewData["ProspectId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
                        }
                    }
                    else
                    {
                        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        var userGUID = (Guid.Parse(userId));
                        if (Id != null)
                        {
                            var contactId = Id ?? Guid.Empty; ;
                            var contact = await _contactRepo.GetbyIdAsync(contactId);
                            ViewData["ProspectId"] = new SelectList(_context.Contacts.Where(e => e.ContactOwnerID == userGUID), "Contact_Id", "FullName", contact.Contact_Id);
                        }
                        else
                        {
                            ViewData["ProspectId"] = new SelectList(_context.Contacts.Where(e => e.ContactOwnerID == userGUID), "Contact_Id", "FullName");
                        }
                    }
                }
            
            return View("~/Views/Records/Leads/Create.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Leads leadsCreate)
        {
            if (ModelState.IsValid)
            {
                leadsCreate.CreatedDate = DateTime.Now;
                var users = _userManager.GetUserId(HttpContext.User);
                leadsCreate.CreatedBy = Guid.Parse(users);
                await _leads.CreateAsync(leadsCreate);
                TempData["SuccessMessage"] = $"Congratulations! You have successfully created a new lead .";
                TempData.Keep();
                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/Records/Leads/Create.cshtml", leadsCreate);
        }

        public async Task<IActionResult> Edit(Guid id )
        {
            var leadsEdit = await _leads.GetbyIdAsync(id);

            if (leadsEdit == null)
            {
                return NotFound();
            }

            var leadContactID = leadsEdit?.ProspectId;
            var LeadContact = await _contactRepo.GetbyIdAsync(leadContactID ?? Guid.Empty);
            var LeadContactOwner = LeadContact.ContactCreatorID;
            ViewData["StatusId"] = new SelectList(_context.Statuses, "LeadStatus_Id", "LeadStatusName");
            ViewData["ProductId"] = new SelectList(_context.Products, "Product_Id", "ProductName");
            //LEADSOURCE VIEW DATA
            if (LeadContactOwner != null)
            {
                ViewData["LeadSourceId"] = new SelectList(_context.Sources, "Source_Id", "SourceName");
            }
            else
            {
                var items = _context.Sources
                .Where(s => s.SourceName == "Company-Generated")
                .Select(s => new SelectListItem { Text = s.SourceName, Value = s.Source_Id.ToString() })
                .ToList();
                ViewData["LeadSourceId"] = new SelectList(items, "Value", "Text");
            }
            
            //PROSPECT ID VIEW DATA
            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                    ViewData["ProspectId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
                }
                else
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var userGUID = (Guid.Parse(userId));
                    ViewData["ProspectId"] = new SelectList(_context.Contacts.Where(e => e.ContactOwnerID == userGUID), "Contact_Id", "FullName");
                }
            }

          
            return View("~/Views/Records/Leads/Edit.cshtml", leadsEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Leads_Id, " +
            "Leads_DateTime, PrefContactMethod, PrefContactDay, PrefContactTime, CreatedDate, " +
            "ProspectId, ProductId, StatusId, LeadSourceId, CreatedBy")] Leads leadsEdit)
        {
            if (id != leadsEdit.Leads_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _leads.UpdateAsync(leadsEdit);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordLeadsExists(leadsEdit.Leads_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["SuccessMessage"] = $"SUCCESS! You have successfully updated your lead's information.";
                TempData.Keep();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusId"] = new SelectList(_context.Statuses, "LeadStatus_Id", "LeadStatusName");
            ViewData["LeadSourceId"] = new SelectList(_context.Sources, "Source_Id", "SourceName");
            ViewData["ProspectId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
            ViewData["ProductId"] = new SelectList(_context.Products, "Product_Id", "ProductName");
            return View("~/Views/Records/Leads/Edit.cshtml", leadsEdit);
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            var leadPurpose = await _leads.GetbyIdAsync(id);
            if (leadPurpose == null)
            {
                return NotFound();
            }
            //ViewBag.Engagement_Id = id;
            return View("~/Views/Records/Leads/Delete.cshtml", leadPurpose);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Deleted(Guid id)
        {
            if (_leads == null)
            {
                return Problem("Entity set 'CRMSDbContext'  is null.");
            }

            if (id == Guid.Empty)
            {
                return NotFound();
            }


            var engagement = await _leads.GetbyIdAsync(id);

            if (engagement != null)
            {
                await _leads.DeleteAsync(id);
                TempData["SuccessMessage"] = $"SUCCESS! You have successfully DELETED a lead data.";
                TempData.Keep();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool RecordLeadsExists(Guid id)
        {
            return (_leads.GetbyIdAsync(id) is not null);
        }

    }
}
