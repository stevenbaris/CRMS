using CRMS.Data;
using CRMS.Models;
using CRMS.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly CRMSDbContext _crmsDbContext;

        public AccountController(
            CRMSDbContext crmsDbContext,
            RoleManager<IdentityRole<Guid>> roleManager,
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _crmsDbContext = crmsDbContext;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            IndexUserViewModel model = new IndexUserViewModel
            {
                Roles = _roleManager.Roles
            };
            
            return View(model);
        }
    }
}
