using CRMS.Data;
using CRMS.Models;
using CRMS.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    public class UserController : Controller
    {
        ICRMSRepository _repo;

        public UserController(ICRMSRepository repo)
        {
            _repo = repo;
        }

        public IActionResult GetAllUsers()
        {
            var userlist = _repo.GetAllUsers();
            return View(userlist);
        }
        public IActionResult Details(Guid userId)
        {
            var user = _repo.GetUserById(userId);
            return View(user);
        }
        public IActionResult Delete(Guid userId)
        {
            var userlist = _repo.DeleteUser(userId);
            return RedirectToAction(controllerName: "User", actionName: "GetAllUsers"); // reload the getall page it self
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User newUser) // model binded this where the views data is accepted 
        {
            if (ModelState.IsValid)
            {
                var user = _repo.AddUser(newUser);
                return RedirectToAction("GetAllUsers");
            }
            ViewData["Message"] = "Data is not valid to create the User";
            return View();
        }

        [HttpGet]
        public IActionResult Update(Guid userId)
        {
            var oldUser = _repo.GetUserById(userId);
            return View(oldUser);
        }
        [HttpPost]
        public IActionResult Update(User newUser)
        {
            var user = _repo.UpdateUser(newUser.UserId, newUser);
            return RedirectToAction("GetAllUsers");
        }
    }
}
