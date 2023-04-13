using CRMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signinManager;
public HomeController(SignInManager<ApplicationUser> signinManager)
        {
            _signinManager = signinManager;
        }

        public IActionResult Index()
        {
            if (_signinManager.IsSignedIn(User))
            {
                if (User.IsInRole("Admin"))
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            return RedirectToAction("Login", "User");
        }


        public IActionResult Marketing()
        {
            return View();
        }

        public IActionResult CustomerService()
        {
            return View();
        }
    }
}
