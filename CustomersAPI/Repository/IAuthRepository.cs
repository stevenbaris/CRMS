using CustomersAPI.DTO;
using CustomersAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace CustomersAPI.Repository
{
    public interface IAuthRepository
    {
        Task<ApplicationUser> SignUpUserAsync(ApplicationUser user, string password);
        Task<SignInResult> SignInUserAsync(LoginDTO loginDTO);
        Task<ApplicationUser> FindUserByEmailAsync(string email);
    }
}
