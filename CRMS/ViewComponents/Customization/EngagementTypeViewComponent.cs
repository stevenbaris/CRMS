using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Customization
{
    public class EngagementTypeViewComponent:ViewComponent
    {

        private readonly IRepository<EngagementType> _eTypeRepo;

        public EngagementTypeViewComponent(IRepository<EngagementType> eTypeRepo)
        {
            _eTypeRepo = eTypeRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var eType = await _eTypeRepo.GetAllAsync();
            return View(eType);
        }
    }
}
