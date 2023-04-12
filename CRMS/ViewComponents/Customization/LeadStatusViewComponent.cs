using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Customization
{
    public class LeadStatusViewComponent:ViewComponent
    {
        private readonly IRepository<LeadStatus> _statusRepo;

        public LeadStatusViewComponent(IRepository<LeadStatus> statusRepo)
        {
            _statusRepo = statusRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var status = await _statusRepo.GetAllAsync();
            return View(status);
        }
    }
}
