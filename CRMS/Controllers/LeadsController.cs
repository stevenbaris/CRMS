using CRMS.Data;
using CRMS.Models;
using CRMS.Models.Records;
using CRMS.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Controllers
{
    public class LeadsController : Controller
    {
        private readonly IRepository<Leads> _leads;
        private readonly CRMSDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public LeadsController(IRepository<Leads> leads, CRMSDbContext context, UserManager<ApplicationUser> userManager)
        {
            _leads = leads;
            _context = context;
            _userManager = userManager;
        }

       public async Task<IActionResult> Index()
        {
            var leadsIndex = await _leads.GetAllAsync();
            var CRMSDbContext = await _context.Leads
                .Include(ur => ur.prospect)
                .Include(ur => ur.status)
                .Include(ur => ur.source)
                .Include(ur => ur.User)
                .Include(ur => ur.product)
                .ToListAsync();
            return View("~/Views/Records/Leads/Index.cshtml", leadsIndex);
            //return View("~/Views/Records/Leads/Index.cshtml", await eMSDbContext.ToListAsync());
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

        public IActionResult Create()
        {
            ViewData["StatusId"] = new SelectList(_context.Statuses, "LeadStatus_Id", "LeadStatusName");
            ViewData["LeadSourceId"] = new SelectList(_context.Sources, "Source_Id", "SourceName");
            ViewData["ProspectId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
            ViewData["ProductId"] = new SelectList(_context.Products, "Product_Id", "ProductName");
            //View Data for product
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
                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/Records/Leads/Create.cshtml", leadsCreate);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var leadsEdit = await _leads.GetbyIdAsync(id);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "LeadStatus_Id", "LeadStatusName");
            ViewData["LeadSourceId"] = new SelectList(_context.Sources, "Source_Id", "SourceName");
            ViewData["ProspectId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
            ViewData["ProductId"] = new SelectList(_context.Products, "Product_Id", "ProductName");
            if (leadsEdit == null)
            {
                return NotFound();
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
            if (leadPurpose != null)
            {
                await _leads.DeleteAsync(id);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool RecordLeadsExists(Guid id)
        {
            return (_leads.GetbyIdAsync(id) is not null);
        }

    }
}
