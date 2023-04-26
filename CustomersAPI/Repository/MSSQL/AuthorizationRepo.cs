using CustomersAPI.DTO;
using CustomersAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CustomersAPI.Repository.MSSQL
{
    public class AuthorizationRepo : IAuthRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public AuthorizationRepo(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<Microsoft.AspNetCore.Identity.SignInResult> SignInUserAsync(LoginDTO loginDTO)
        {
            var loginResult = await _signInManager.PasswordSignInAsync(loginDTO.UserName, loginDTO.Password, loginDTO.RememberMe, false);
            return loginResult;
        }

        public async Task<ApplicationUser> SignUpUserAsync(ApplicationUser user, string password)
        {
            // Check if the user already exists
            var newUser = await _userManager.CreateAsync(user, password);
            if (newUser.Succeeded)
                return user;
            return null;

        }

        public async Task<ApplicationUser> FindUserByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user;
        }
    }
}


