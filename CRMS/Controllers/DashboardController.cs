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
            var leadSources = (await _leadsRepo.GetAllAsync())
                    .Join((await _leadSourcesRepo.GetAllAsync()), l => l.LeadSourceId, ls => ls.Source_Id, (l, ls) => new { Lead = l, LeadSource = ls })
                    .GroupBy(x => x.LeadSource.SourceName)
                    .Select(g => new { Source = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Take(5)
                    .ToList();

            ViewData["LeadSources"] = leadSources;
            ViewData["ActivityToday"] = GetTheDaysActivity(DateTime.Now).Result;
            ViewData["ActivityYesterday"] = GetTheDaysActivity(DateTime.Now.AddDays(-1));

            return View();
        }

        public async Task<int> GetTheDaysActivity(DateTime? inq_date)
        {
            var user = _userManager.GetUserAsync(User).Result;

            var contacts = _contactRepo.GetAllMyContactsAsync(user.Id);
                
            var activity = new DashboardActivity
            {
                ContactsWithNoLeads = (await _contactRepo.GetAllAsync())
                    .GroupJoin(
                        await _leadsRepo.GetAllAsync(),
                        c => c.Contact_Id,
                        l => l.CreatedBy,
                        (c, ls) => new { Contact = c, Leads = ls })
                    .Where(cl => !cl.Leads.Any())
                    .Count(),
                NextEngagements = (await _engagementRepo.GetAllAsync()).Where(e=>e.CreatedDate.AddDays(7) == inq_date).Count(),
                Appointments = (await _appointmentRepo.GetAllAsync()).Count(a => a.Appointment_DateTime == inq_date),
            };

            var totalActivity = activity.ContactsWithNoLeads + activity.NextEngagements + activity.Appointments;
            return totalActivity;
        }

        public class DashboardActivity
        {
            public int ContactsWithNoLeads { get; set; }
            public int NextEngagements { get; set; }
            public int Appointments { get; set; }
            
        }
    }
}
