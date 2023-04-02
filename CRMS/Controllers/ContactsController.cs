using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
