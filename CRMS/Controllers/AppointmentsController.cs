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
using CRMS.Services.Contacts_Services;
using System.Security.Claims;
using CRMS.Services.Records;

namespace CRMS.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly IRepository<Appointments> _appointments;
        private readonly IContactRepository _contacts;
        private readonly CRMSDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AppointmentsController(
            IRepository<Appointments> appointments,
            CRMSDbContext context,
            UserManager<ApplicationUser> userManager,
            IContactRepository contacts,
            SignInManager<ApplicationUser> signInManager)

        {
            _appointments = appointments;
            _context = context;
            _userManager = userManager;
            _contacts = contacts;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var appointmentIndex = await _appointments.GetAllAsync();

            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                    return View("~/Views/Records/Appointment/Index.cshtml", appointmentIndex);
                }
                else
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var myAppointments = appointmentIndex.Where(l => l.CreatedBy == Guid.Parse(userId));
                    return View("~/Views/Records/Appointment/Index.cshtml", myAppointments);
                }
            }

            return RedirectToAction("Index", "Home");
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

        public async Task<IActionResult> Create(Guid? Id)
        {

            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Purpose_Id", "PurposeName");
            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                    if (Id != null)
                    {
                        var contact = await _contacts.GetbyIdAsync(Id.Value);
                        ViewData["ContactId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName", contact.Contact_Id);
                    }
                    else
                    {
                        ViewData["ContactId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
                    }
                }
                else
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var userGUID = (Guid.Parse(userId));
                    if (Id != null)
                    {
                        var contact = await _contacts.GetbyIdAsync(Id.Value);
                        ViewData["ContactId"] = new SelectList(_context.Contacts.Where(e => e.ContactOwnerID == userGUID), "Contact_Id", "FullName", contact.Contact_Id);
                    }
                    else
                    {
                        ViewData["ContactId"] = new SelectList(_context.Contacts.Where(e => e.ContactOwnerID == userGUID), "Contact_Id", "FullName");
                    }
                }
            }
            return View("~/Views/Records/Appointment/Create.cshtml")    ;

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
            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Purpose_Id", "PurposeName");
            ViewData["ContactId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
            return View("~/Views/Records/Appointment/Create.cshtml", appointmentCreate);
        }

        public async Task<IActionResult> Edit(Guid Id, Guid? contactId)
        {
            var appointmentEdit = await _appointments.GetbyIdAsync(Id);
            if (appointmentEdit == null)
            {
                return NotFound();
            }

            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Purpose_Id", "PurposeName");

            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                        ViewData["ContactId"] = new SelectList(_context.Contacts, "Contact_Id", "FullName");
                }
                else
                {
                        ViewData["ContactId"] = new SelectList(_context.Contacts.Where(e => e.ContactOwnerID == appointmentEdit.CreatedBy), "Contact_Id", "FullName");
                }
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
            if (appointmentPurpose == null)
            {
                return NotFound();
            }
            //ViewBag.Engagement_Id = id;
            return View("~/Views/Records/Appointment/Delete.cshtml", appointmentPurpose);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Deleted(Guid id)
        {
            if (_appointments == null)
            {
                return Problem("Entity set 'CRMSDbContext'  is null.");
            }

            if (id == Guid.Empty)
            {
                return NotFound();
            }


            var engagement = await _appointments.GetbyIdAsync(id);

            if (engagement != null)
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
