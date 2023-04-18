using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Models.Records;
using CRMS.Services;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
            var user = _userManager.GetUserAsync(User).Result;
            var contacts = await _contactRepo.GetAllMyContactsAsync(user.Id);


            var leadSources = (await _leadsRepo.GetAllAsync())
                    .Join((await _leadSourcesRepo.GetAllAsync()), l => l.LeadSourceId, ls => ls.Source_Id, (l, ls) => new { Lead = l, LeadSource = ls })
                    .GroupBy(x => x.LeadSource.SourceName)
                    .Select(g => new { Source = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Take(5)
                    .ToList();

            var ContactsWithNoLeads = (contacts)
                    .GroupJoin(
                        await _leadsRepo.GetAllAsync(),
                        c => c.Contact_Id,
                        l => l.CreatedBy,
                        (c, ls) => new { Contact = c, Leads = ls });

            var NextEngagements =(await _engagementRepo.GetAllAsync()).Where(e => e.CreatedDate.AddDays(7) == DateTime.Now).Count();
            var Appointments = (await _appointmentRepo.GetAllAsync()).Count(a => a.Appointment_DateTime == DateTime.Now);

            ViewData["LeadSources"] = leadSources;
            ViewData["ContactsWithNoLeads"] = ContactsWithNoLeads;
            ViewData["NextEngagements"] = NextEngagements;
            ViewData["Appointments"] = Appointments;

            //ViewData["ActivityToday"] = GetTheDaysActivity(DateTime.Now).Result;
            //ViewData["ActivityYesterday"] = GetTheDaysActivity(DateTime.Now.AddDays(-1));


            return View();
        }

        
        
    }
}
