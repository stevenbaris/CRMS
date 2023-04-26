using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Customization
{
    public class CommsMethodViewComponent:ViewComponent
    {
        private readonly IRepository<CommunicationMethod> _commsMethodRepo;

        public CommsMethodViewComponent(IRepository<CommunicationMethod> commsMethodRepo)
        {
            _commsMethodRepo = commsMethodRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var commsMethod = await _commsMethodRepo.GetAllAsync();
            return View(commsMethod);
        }
    }
}
