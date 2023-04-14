using CRMS.Data;
using CRMS.Models.Customization;
using CRMS.Models.Records;
using CRMS.Services;
using CRMS.Services.SqlRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRMS.Models;

namespace CRMS.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly IRepository<Appointments> _appointments;
        private readonly CRMSDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public AppointmentsController(
            IRepository<Appointments> appointments,
            CRMSDbContext context, 
            UserManager<ApplicationUser> userManager)

        {
            _appointments = appointments;
            _context = context;
            _userManager = userManager; 
        }

        public async Task<IActionResult> Index()
        {
            var appointmentIndex = await _appointments.GetAllAsync();
            var CRMSDbContext = await _context.Appointments.Include(ur => ur.prospect)
                .Include(ur => ur.AppointmentPurpose)
                .Include(ur => ur.User)
                .ToListAsync();
            return View("~/Views/Records/Appointment/Index.cshtml" , CRMSDbContext);
            //return View("~/Views/Records/Appointment/Index.cshtml", await eMSDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var appointmentDetails = await _appointments.GetbyIdAsync(id);
            if (appointmentDetails == null)
            {
                return NotFound();
            }

            return View("~/Views/Customization/Components/Purpose/AppointmentPurposes/Details.cshtml", appointmentDetails);
        }

        public IActionResult Create()
        {
            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Purpose_Id", "PurposeName");
            ViewData["ContactId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
            return View("~/Views/Records/Appointment/Create.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Appointments appointmentCreate)
        {
            if (ModelState.IsValid)
            {
                appointmentCreate.CreatedDate = DateTime.Now;

                var users = _userManager.GetUserId(HttpContext.User);
                appointmentCreate.CreatedBy = Guid.Parse(users);
                await _appointments.CreateAsync(appointmentCreate);
                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/Records/Appointment/Create.cshtml", appointmentCreate);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var appointmentEdit = await _appointments.GetbyIdAsync(id);
            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Purpose_Id", "PurposeName");
            ViewData["ContactId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
            if (appointmentEdit == null)
            {
                return NotFound();
            }
            return View("~/Views/Records/Appointment/Edit.cshtml", appointmentEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Appointment_Id, " +
            "Appointment_DateTime, Description, SchedStatus, PurposeId, ContactId, CreatedDate, CreatedBy")] Appointments appointmentEdit)
        {
            if (id != appointmentEdit.Appointment_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _appointments.UpdateAsync(appointmentEdit);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordAppointmentExists(appointmentEdit.Appointment_Id))
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
            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Purpose_Id", "PurposeName");
            ViewData["ContactId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
            return View("~/Views/Records/Appointment/Edit.cshtml", appointmentEdit);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var appointmentPurpose = await _appointments.GetbyIdAsync(id);
            if (appointmentPurpose != null)
            {
                await _appointments.DeleteAsync(id);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool RecordAppointmentExists(Guid id)
        {
            return (_appointments.GetbyIdAsync(id) is not null);
        }
    }
}
