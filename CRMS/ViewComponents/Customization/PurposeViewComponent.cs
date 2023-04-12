using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Customization
{
    public class PurposeViewComponent : ViewComponent
    {
        private readonly IRepository<AppointmentPurpose> _purposeRepo;

        public PurposeViewComponent(IRepository<AppointmentPurpose> purposeRepo)
        {
            _purposeRepo = purposeRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var purpose = await _purposeRepo.GetAllAsync();
            return View(purpose);
        }
    }
}
