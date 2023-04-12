using CRMS.Models;
using CRMS.Repository;
using CRMS.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRMS.Controllers
{
    public class UserController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public UserController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
           SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var userModel = new ApplicationUser
                {
                    UserName = userViewModel.Email,
                    Email = userViewModel.Email,
                    FirstName = userViewModel.FirstName,
                    LastName = userViewModel.LastName,
                    Address = userViewModel.Address
                };
                var result = await _userManager.CreateAsync(userModel, userViewModel.Password);
                if (result.Succeeded)
                {
                    // add roles to it and allow him to login
                    //var roles = _roleManager.Roles.ToList();                

                    // login the user automatically
                    // await _signInManager.SignInAsync(userModel, isPersistent: false);
                    return RedirectToAction("Index", "User");

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(userViewModel);
        }


        public IActionResult Index()
        {
            var users = _unitOfWork.User.GetUsers();
            return View(users);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var user = _unitOfWork.User.GetUser(id);
            var roles = _unitOfWork.Role.GetRoles();

            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);

            var roleItems = roles.Select(role =>
                new SelectListItem(
                    role.Name,
                    role.Id.ToString(),
                    userRoles.Any(ur => ur.Contains(role.Name)))).ToList();

            var vm = new EditUserViewModel
            {
                User = user,
                Roles = roleItems
            };

            return View(vm);
        }

        //[HttpPost]
        //public async Task<IActionResult> OnPostAsync(EditUserViewModel data)
        //{
        //    var user = _unitOfWork.User.GetUser(data.User.Id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    var userRolesInDb = await _signInManager.UserManager.GetRolesAsync(user);

        //    //Loop through the roles in ViewModel
        //    //Check if the Role is Assigned In DB
        //    //If Assigned -> Do Nothing
        //    //If Not Assigned -> Add Role

        //    var rolesToAdd = new List<string>();
        //    var rolesToDelete = new List<string>();

        //    foreach (var role in data.Roles)
        //    {
        //        var assignedInDb = userRolesInDb.FirstOrDefault(ur => ur == role.Text);
        //        if (role.Selected)
        //        {
        //            if (assignedInDb == null)
        //            {
        //                rolesToAdd.Add(role.Text);
        //            }
        //        }
        //        else
        //        {
        //            if (assignedInDb != null)
        //            {
        //                rolesToDelete.Add(role.Text);
        //            }
        //        }
        //    }

        //    if (rolesToAdd.Any())
        //    {
        //        await _signInManager.UserManager.AddToRolesAsync(user, rolesToAdd);
        //    }

        //    if (rolesToDelete.Any())
        //    {
        //        await _signInManager.UserManager.RemoveFromRolesAsync(user, rolesToDelete);
        //    }

        //    user.FirstName = data.User.FirstName;
        //    user.LastName = data.User.LastName;
        //    user.Email = data.User.Email;

        //    _unitOfWork.User.UpdateUser(user);

        //    // return RedirectToAction("Edit", new { id = user.Id });
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                // login activity -> cookie [Roles and Claims]
                var result = await _signInManager.PasswordSignInAsync(userViewModel.UserName, userViewModel.Password, userViewModel.RememberMe, false);
                //login cookie and transfter to the client 
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "User");
                }
                ModelState.AddModelError(string.Empty, "invalid login credentials");
            }
            return View(userViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User cannot be found";
                return View("Not Found");
            }
            else
            {
                var result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("Index");
            }
        }
    }
}
