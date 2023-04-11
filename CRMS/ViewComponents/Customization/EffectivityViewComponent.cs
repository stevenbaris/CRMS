using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Customization
{
    public class EffectivityViewComponent:ViewComponent
    {
        private readonly IRepository<Effectivity> _effRepo;

        public EffectivityViewComponent(IRepository<Effectivity> effRepo)
        {
            _effRepo = effRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var effectivity = await _effRepo.GetAllAsync();
            return View(effectivity);
        }
    }
}
