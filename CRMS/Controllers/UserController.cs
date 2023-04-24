using CRMS.Data;
using CRMS.Exceptions;
using CRMS.Models;
using CRMS.Services;
using CRMS.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Security.Claims;

namespace CRMS.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
    public class UserController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly CRMSDbContext _crmsDbContext;


        public UserController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
           SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole<Guid>> roleManager, CRMSDbContext cRMSDbContext)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _crmsDbContext = cRMSDbContext;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel userViewModel)
        {

            if (!ModelState.IsValid)
            {
                return View(userViewModel);
            }

            var result = await _signInManager.PasswordSignInAsync(userViewModel.UserName, userViewModel.Password, userViewModel.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Invalid login credential.");
                return View(userViewModel);
            }

            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> AdminLogin(AdminLoginViewModel userViewModel)
        {
            var user = await _userManager.FindByNameAsync(userViewModel.UserName);

            if (user != null && await _userManager.CheckPasswordAsync(user, userViewModel.Password))
            {
                var result = await _signInManager.PasswordSignInAsync(userViewModel.UserName, userViewModel.Password, false, false);
                bool isAdmin = await _userManager.IsInRoleAsync(user, "Admin");

                if (result.Succeeded && isAdmin)
                {
                    // Redirect the user to the admin dashboard
                    return RedirectToAction(actionName: "Index", controllerName: "Home");
                }
            }

            // Return an error message indicating that the user does not have access to the admin section
            ModelState.AddModelError("", "Invalid Administrator credentials");
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var role in _roleManager.Roles)
            {
                list.Add(new SelectListItem() { Value = role.Name, Text = role.Name });
            }

            ViewBag.RoleName = list;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel createUserViewModel)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var role in _roleManager.Roles)
            {
                list.Add(new SelectListItem() { Value = role.Name, Text = role.Name });
            }

            ViewBag.RoleName = list;

            if (!ModelState.IsValid)
            {
                return View(createUserViewModel);
            }

            var user = new ApplicationUser
            {
                UserName = createUserViewModel.Email,
                Email = createUserViewModel.Email,
                FirstName = createUserViewModel.FirstName,
                LastName = createUserViewModel.LastName,
                CityAddress = createUserViewModel.Address,
            };

            var emailExist = _crmsDbContext.Users.Any(x => x.Email == user.Email);

            if (emailExist)
            {
                ModelState.AddModelError("Email", "Email already exist!");
                return View();
            }

            var result = await _userManager.CreateAsync(user, createUserViewModel.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Creation failed.");
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(createUserViewModel);
            }

            //Add Role
            await _userManager.AddToRoleAsync(user, createUserViewModel.RoleName);

            TempData["SuccessMessage"] = $"SUCCESS! You have successfully added the User: {user.FullName} with {createUserViewModel.RoleName} role .";
            TempData.Keep();

            return RedirectToAction(actionName: "Index", controllerName: "User");
        }

        public async Task<IActionResult> Index()
        {

            //var users = await _userManager.Users.Select(async user => new IndexUserViewModel
            //{
            //    Id = user.Id,
            //    FirstName = user.FirstName,
            //    LastName = user.LastName,
            //    Email = user.Email,
            //    Role = (await _userManager.GetRolesAsync(user)).ToList
            //}).ToListAsync();

            var users = await _userManager.Users.ToListAsync();
            var usersWithRoles = new List<IndexUserViewModel>();


            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var userViewModel = new IndexUserViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Role = roles.ToList()
                };
                usersWithRoles.Add(userViewModel);
            }


            if (TempData["SuccessMessage"] != null)
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }
            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"];
            }

            return View(usersWithRoles);
        }

        public async Task<IActionResult> IndexRole(string sortOrder)
        {

            var users = await _userManager.GetUsersInRoleAsync("admin");
            return View(users);
        }

        public async Task<IActionResult> IndexNoRole()
        {
            var usersWithoutAnyRole = _crmsDbContext.Users
                .Where(c => !_crmsDbContext.UserRoles
                .Select(b => b.UserId).Distinct()
                .Contains(c.Id)).ToList();
            return View(usersWithoutAnyRole);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var user = _unitOfWork.User.GetUser(id);

            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);
            var uRole = userRoles.FirstOrDefault();

            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var role in _roleManager.Roles)
            {
                list.Add(new SelectListItem() { Value = role.Name, Text = role.Name });
            }

            ViewBag.RoleName = list;

            var vm = new EditUserViewModel
            {
                User = user,
                Role = uRole
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel data)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var role in _roleManager.Roles)
            {
                list.Add(new SelectListItem() { Value = role.Name, Text = role.Name });
            }

            ViewBag.RoleName = list;

            var user = _unitOfWork.User.GetUser(data.User.Id);
            if (user == null)
            {
                return NotFound();
            }
                        
            var userRolesInDb = await _userManager.GetRolesAsync(user);
            var uRole = userRolesInDb.FirstOrDefault();
            if (uRole != null)
            {
                var romoveRole = await _userManager.RemoveFromRoleAsync(user, uRole);
            }
            var addtoRole = await _userManager.AddToRoleAsync(user, data.Role);
           

            user.FirstName = data.User.FirstName;
            user.LastName = data.User.LastName;
            user.Email = data.User.Email;
            user.CityAddress = data.User.CityAddress;

            _unitOfWork.User.UpdateUser(user);
            TempData["SuccessMessage"] = $"SUCCESS! You have successfully updated the user data.";
            TempData.Keep();

            // return RedirectToAction("Edit", new { id = user.Id });
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
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
                return NotFound();
            }
            else
            {
                var result = await _userManager.DeleteAsync(user);
                return View(user);
            }
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_userManager.Users == null)
            {
                throw new RepositoryNullException("Application User table is null.");
            }
            var deleteAppUser = await _userManager.FindByIdAsync(id.ToString());
            
            if (deleteAppUser != null)
            {
                await _userManager.DeleteAsync(deleteAppUser);
               
            }
            TempData["SuccessMessage"] = $"SUCCESS! You have successfully DELETED the User.";
            TempData.Keep();

            return RedirectToAction("Index");
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ManageProfile()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var AppUser = await _userManager.FindByIdAsync(userId);

                var profileModel = new ManageAccountViewModel
                {
                    FirstName = AppUser.FirstName,
                    LastName = AppUser.LastName,
                    Address = AppUser.CityAddress,
                    Email = AppUser.Email,
                    Username = AppUser.UserName
                };
                
                return View(profileModel);
            }

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ManageProfile(ManageAccountViewModel MAViewmodel)
        {
            try
            {
                if (!_signInManager.IsSignedIn(User))
                {
                    return RedirectToAction("Login");
                }

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(userId, out var userGUID))
                {
                    return BadRequest("Invalid user ID");
                }

                var AppUser = await _userManager.FindByIdAsync(userId);
                if (AppUser == null)
                {
                    return NotFound("User not found");
                }

                if (!ModelState.IsValid)
                {
                    return View(MAViewmodel);
                }

                AppUser.FirstName = MAViewmodel.FirstName;
                AppUser.LastName = MAViewmodel.LastName;
                AppUser.CityAddress = MAViewmodel.Address;
                AppUser.Email = MAViewmodel.Email;
                //USERNAME ASSIGNMENT
                AppUser.UserName = User.IsInRole("Admin") ? MAViewmodel.Username : MAViewmodel.Email;

                //CHECK PASsWORD
                if (!string.IsNullOrEmpty(MAViewmodel.ExistingPassword) || !string.IsNullOrEmpty(MAViewmodel.NewPassword) || !string.IsNullOrEmpty(MAViewmodel.ConfirmNewPassword))
                {
                    if (string.IsNullOrEmpty(MAViewmodel.NewPassword))
                    {
                        //ModelState.AddModelError("", "New password is required.");
                        return View(MAViewmodel);
                    }

                    if (string.IsNullOrEmpty(MAViewmodel.ConfirmNewPassword))
                    {
                        //ModelState.AddModelError("", "Confirm new password is required.");
                        return View(MAViewmodel);
                    }
                    if (string.IsNullOrEmpty(MAViewmodel.ExistingPassword))
                    {
                        //ModelState.AddModelError("", "Existing password is required.");
                        return View(MAViewmodel);
                    }

                    var verifiedOldPassword = await _userManager.ChangePasswordAsync(AppUser, MAViewmodel.ExistingPassword, MAViewmodel.NewPassword);
                    if (!verifiedOldPassword.Succeeded)
                    {
                        foreach (var error in verifiedOldPassword.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(MAViewmodel);
                    }

                }
               

                var updateProfile = await _userManager.UpdateAsync(AppUser);

                if (!updateProfile.Succeeded)
                {
                    ModelState.AddModelError("", "Failed to update user profile.");
                    return View(MAViewmodel);
                }


                TempData["SuccessMessage"] = "SUCCESS! Your profile has been successfully updated.";
                return RedirectToAction("ManageProfile", "User");
            }

            catch (Exception ex)
            {
                // log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
          
        }

        
        public async Task<IActionResult> ResetPassword(Guid Id)
        {
            var user = await _userManager.FindByIdAsync(Id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            var newPassword = "@CoreUser" + DateTime.Now.ToString("MMdd");
            var remove = await _userManager.RemovePasswordAsync(user);
            if (!remove.Succeeded)
            {
                TempData["ErrorMessage"] = $"FAILED! Cannot remove the old password for User: {user.FullName}.";
                TempData.Keep();
                return RedirectToAction("Index");
            }
            var add = await _userManager.AddPasswordAsync(user, newPassword);
            if (!remove.Succeeded)
            {
                TempData["ErrorMessage"] = $"UNSUCCESSFUL! Failed to reset the password for User: {user.FullName}.";
                TempData.Keep();
                return RedirectToAction("Index");
            }
            TempData["SuccessMessage"] = $"SUCCESS! You have successfully reset the password for User: {user.FullName}. The New Password is: {newPassword}";
            TempData.Keep();
            return RedirectToAction("Index");
        }

    }
}
