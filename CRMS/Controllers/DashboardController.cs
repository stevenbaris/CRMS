using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Models.Records;
using CRMS.Services;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CRMS.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IRepository<Leads> _leadsRepo;
        private readonly IRepository<Engagement> _engagementRepo;
        private readonly IRepository<Appointments> _appointmentRepo;
        private readonly IRepository<Source> _leadSourcesRepo;
        private readonly IContactRepository _contactRepo;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public DashboardController(
            IRepository<Leads> leadsRepo,
            IRepository<Engagement> engagementRepo,
            IRepository<Appointments> appointmentRepo,
            IContactRepository contactRepo,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IRepository<Source> leadSourcesRepo)
        {
            _leadsRepo = leadsRepo;
            _engagementRepo = engagementRepo;
            _appointmentRepo = appointmentRepo;
            _contactRepo = contactRepo;
            _userManager = userManager;
            _signInManager = signInManager;
            _leadSourcesRepo = leadSourcesRepo;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userGUID = Guid.Parse(userId);
            var contacts = await _contactRepo.GetAllMyContactsAsync(userGUID);
            var leads = (await _leadsRepo.GetAllAsync()).Where(lead => lead.CreatedBy == userGUID);


            var leadSources = (await _leadsRepo.GetAllAsync()).Where(lead=>lead.CreatedBy ==  userGUID)
                    .Join((await _leadSourcesRepo.GetAllAsync()), l => l.LeadSourceId, ls => ls.Source_Id, (l, ls) => new { Lead = l, LeadSource = ls })
                    .GroupBy(x => x.LeadSource.SourceName)
                    .Select(g => new { Source = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Take(5)
                    .ToList();

            var ContactsWithNoLeads = (contacts)
                     .Where(c => !leads.Any(l => l.CreatedBy == c.Contact_Id)).Count();
            
            var NextEngagements = (await _engagementRepo.GetAllAsync()).Count(e=>e.Engagement_Date.AddDays(7).Date == DateTime.Now.Date  && e.CreatedById == userGUID);
            var Appointments = (await _appointmentRepo.GetAllAsync()).Count(a => a.Appointment_DateTime.Date == DateTime.Now.Date && a.CreatedBy == userGUID);

            var ContactsCreated = (await _contactRepo.GetAllAsync()).Where(c=>c.ContactCreatorID == userGUID);
            var ContactsAssigned = (await _contactRepo.GetAllAsync()).Where(c => c.ContactCreatorID != userGUID  && c.ContactOwnerID == userGUID);

            ViewData["LeadSources"] = leadSources;
            ViewData["ContactsWithNoLeads"] = ContactsWithNoLeads;
            ViewData["NextEngagements"] = NextEngagements;
            ViewData["Appointments"] = Appointments;
            ViewData["TotalTasks"] = Appointments + Appointments + ContactsWithNoLeads;
            ViewData["ContactsCreated"] = ContactsCreated.Count();
            ViewData["ContactsAssigned"] = ContactsAssigned.Count();

            //ViewData["ActivityToday"] = GetTheDaysActivity(DateTime.Now).Result;
            //ViewData["ActivityYesterday"] = GetTheDaysActivity(DateTime.Now.AddDays(-1));


            return View();
        }

        
        
    }
}
