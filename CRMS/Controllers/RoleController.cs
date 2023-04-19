using CRMS.Models;
using CRMS.ViewModels.Role;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole<Guid>> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("~/Views/Customization/Components/Roles/Roles/Create.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole<Guid> identityRole = new IdentityRole<Guid>
                {
                    Name = model.RoleName
                };

                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Role");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View("~/Views/Customization/Components/Roles/Roles/Create.cshtml", model);
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles;
            return View("~/Views/Customization/Components/Roles/Roles/Index.cshtml", roles);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            // Find the role by Role ID
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id.ToString(),
                RoleName = role.Name,
                Users = new List<string>()
            };


            return View("~/Views/Customization/Components/Roles/Roles/Edit.cshtml", model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        public async Task<IActionResult> Edit(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;

                // Update the Role using UpdateAsync
                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                return View("~/Views/Customization/Components/Roles/Roles/Edit.cshtml", model);
            }
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var roles = await _roleManager.FindByIdAsync(id.ToString());

            if (roles == null)
            {
                ViewBag.ErrorMessage = $"User cannot be found";
                return View("Not Found");
            }
            else
            {
                return View("~/Views/Customization/Components/Roles/Roles/Delete.cshtml", roles);
            }
        }

        
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_roleManager.Roles == null)
            {
                return Problem("Entity set 'CRMSDbContext'  is null.");
            }
            var roleToRemove = await _roleManager.FindByIdAsync(id.ToString());
            if (roleToRemove != null)
            {
                await _roleManager.DeleteAsync(roleToRemove);
            }

            return RedirectToAction(nameof(Index));
        }


    }
}




