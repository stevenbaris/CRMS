using Microsoft.AspNetCore.Identity;
using ProductAPI.DTO;
using ProductAPI.Models;

namespace ProductAPI.Repository
{
    public interface IAuthRepository
    {
        Task<ApplicationUser> SignUpUserAsync(ApplicationUser user, string password);
        Task<SignInResult> SignInUserAsync(LoginDTO loginDTO);
        Task<ApplicationUser> FindUserByEmailAsync(string email);
    }
}
