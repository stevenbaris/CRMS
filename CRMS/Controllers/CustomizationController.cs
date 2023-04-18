using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
    public class CustomizationController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index","Role");
        }
    }
}
