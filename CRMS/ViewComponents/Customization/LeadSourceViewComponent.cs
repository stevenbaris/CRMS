using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Customization
{
    public class LeadSourceViewComponent:ViewComponent
    {
        private readonly IRepository<Source> _repoRepo;

        public LeadSourceViewComponent(IRepository<Source> repoRepo)
        {
            _repoRepo = repoRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var source = await _repoRepo.GetAllAsync();
            return View(source);
        }
    }
}
