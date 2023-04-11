using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.ViewComponents.Contacts
{
    public class _UnassignedContactsViewComponent:ViewComponent
    {
        private readonly IContactRepository _contactRepo;

        public _UnassignedContactsViewComponent(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var model = _contactRepo.GetContactsWithoutOwnerAsync().Result;

            return View(model);
        }
    }
}
