using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    public class CustomizationController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index","Role");
        }
    }
}
