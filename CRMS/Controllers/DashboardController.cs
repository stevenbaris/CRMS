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
            // FIND THE CURRENT USER
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userGUID = Guid.Parse(userId);
            var contacts = await _contactRepo.GetAllMyContactsAsync(userGUID);
            var leads = (await _leadsRepo.GetAllAsync()).Where(lead => lead.CreatedBy == userGUID);

            // ACTIVITY CARD
            var ContactsWithNoLeads = (contacts)
                     .Where(c => !leads.Any(l => l.ProspectId == c.Contact_Id));
            
            var NextEngagements = (await _engagementRepo.GetAllAsync())
                .Where(e =>  e.CreatedById == userGUID) //e.Engagement_Date.AddDays(7).Date == DateTime.Now.Date &&
                .GroupBy(e => e.ContactId)
                .Select(g => g.OrderByDescending(e => e.Engagement_Date)
                  .FirstOrDefault(e => e.Engagement_Date.Date >= DateTime.Now.AddDays(-7).Date))
                .Where(e =>  e?.Engagement_Date.Date == DateTime.Now.AddDays(-7).Date)
                .ToList();

            var Appointments = (await _appointmentRepo.GetAllAsync()).Where(a => a.Appointment_DateTime.Date == DateTime.Now.Date && a.CreatedBy == userGUID && a.SchedStatus == 0);
            var totalTasks = Appointments.Count() + NextEngagements.Count() + ContactsWithNoLeads.Count();

            //TOP LEAD SOURCE CARD
            var leadSources = (await _leadsRepo.GetAllAsync()).Where(lead => lead.CreatedBy == userGUID)
                    .Join((await _leadSourcesRepo.GetAllAsync()), l => l.LeadSourceId, ls => ls.Source_Id, (l, ls) => new { Lead = l, LeadSource = ls })
                    .GroupBy(x => x.LeadSource.SourceName)
                    .Select(g => new { Source = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Take(5)
                    .ToList();

            //CONTACTS CREATED CARD
            var ContactsCreated = (await _contactRepo.GetAllAsync()).Where(c=>c.ContactCreatorID == userGUID && c.CreateDate?.Date == DateTime.Now.Date);
            var ContactsAssigned = (await _contactRepo.GetAllAsync()).Where(c => c.ContactCreatorID != userGUID  && c.ContactOwnerID == userGUID && c.DateAssigned == DateTime.Now.Date);

            var contacted = (await _leadsRepo.GetAllAsync()).Where(l=>l.status.LeadStatusName == "Contacted" && l.CreatedBy == userGUID);
            var met = (await _leadsRepo.GetAllAsync()).Where(l=>l.status.LeadStatusName == "Met" && l.CreatedBy == userGUID);
            var proposal_generated = (await _leadsRepo.GetAllAsync()).Where(l=>l.status.LeadStatusName == "Proposal Generated" && l.CreatedBy == userGUID);
            var application_submitted = (await _leadsRepo.GetAllAsync()).Where(l=>l.status.LeadStatusName == "Application Submitted" && l.CreatedBy == userGUID);
            var policy_issued = (await _leadsRepo.GetAllAsync()).Where(l=>l.status.LeadStatusName == "Policy Issued" && l.CreatedBy == userGUID);
            var dead_lead = (await _leadsRepo.GetAllAsync()).Where(l => l.status.LeadStatusName == "Lead is Dead" && l.CreatedBy == userGUID);



            ViewData["LeadSources"] = leadSources;
            ViewData["ContactsWithNoLeads"] = ContactsWithNoLeads.Count();
            ViewData["NextEngagements"] = NextEngagements.Count();
            ViewData["Appointments"] = Appointments.Count();
            ViewData["ToCreate"] = (10 - ContactsCreated.Count());
            ViewData["TotalTasks"] = (Appointments.Count() + NextEngagements.Count() + ContactsWithNoLeads.Count());
            ViewData["ContactsCreated"] = ContactsCreated.Count();
            ViewData["ContactsAssigned"] = ContactsAssigned.Count();

            ViewData["contacted"] = contacted.Count();
            ViewData["met"] = met.Count();
            ViewData["proposal_generated"] = proposal_generated.Count();
            ViewData["application_submitted"] = application_submitted.Count();
            ViewData["policy_issued"] = policy_issued.Count();
            ViewData["dead_lead"] = dead_lead.Count();

            ViewData["AppointmentsList"] = Appointments;
            ViewData["NextEngagementsList"] = NextEngagements;
            ViewData["ContactsWithNoLeadsList"] = ContactsWithNoLeads;


            //ViewData["ActivityToday"] = GetTheDaysActivity(DateTime.Now).Result;
            //ViewData["ActivityYesterday"] = GetTheDaysActivity(DateTime.Now.AddDays(-1));


            return View();
        }

        
        
    }
}
