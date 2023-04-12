using CRMS.Models;
using CRMS.ViewModels.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public RoleController(RoleManager<IdentityRole<Guid>> roleManager)
        {
            this.roleManager = roleManager;
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

                IdentityResult result = await roleManager.CreateAsync(identityRole);

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
            var roles = roleManager.Roles;
            return View("~/Views/Customization/Components/Roles/Roles/Index.cshtml", roles);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            // Find the role by Role ID
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id.ToString(),
                RoleName = role.Name
            };

            return View("~/Views/Customization/Components/Roles/Roles/Edit.cshtml", model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        public async Task<IActionResult> Edit(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;

                // Update the Role using UpdateAsync
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                return View("~/Views/Customization/Components/Roles/Roles/Edit.cshtml", model);
            }
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = await roleManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User cannot be found";
                return View("Not Found");
            }
            else
            {
                var result = await roleManager.DeleteAsync(user);

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




