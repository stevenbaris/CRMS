using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    public class ProspectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
