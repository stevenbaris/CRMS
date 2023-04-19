using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProductAPI.DTO;
using ProductAPI.Models;
using ProductAPI.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProductAPI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthRepository _authRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(IConfiguration configuration, IAuthRepository authRepository, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _configuration = configuration;
            _authRepository = authRepository;
            _userManager = userManager;
            _mapper = mapper;
        }


        //SIGN-IN or LOG-IN
        [HttpPost("signin")]
        public async Task<IActionResult> Signin([FromBody]LoginDTO user)
        {
            if (ModelState.IsValid)
            {
                var loginResult = await _authRepository.SignInUserAsync(user);
                if (loginResult.Succeeded)
                {
                    var token = GenerateJwtToken();
                    
                    return Ok(new { token });
                } else
                {
                    return Unauthorized();
                }
            }
            return BadRequest();
        }


        //SIGNUP or REGISTER
        [HttpPost("signup")]
        public async Task<IActionResult> Signup([FromBody] RegisterDTO user)
        {
            var existing = await _authRepository.FindUserByEmailAsync(user.Email);
            if (existing != null)
            {
                ModelState.AddModelError("Email", "Email already exists");
                return BadRequest(ModelState);

            }

            var newuser = _mapper.Map<ApplicationUser>(user);

            var result = await _authRepository.SignUpUserAsync(newuser, user.Password);
            
            var token = GenerateJwtToken();

            return Ok(new {token});

        }


        //TOKEN GENERATOR
        private string GenerateJwtToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddMinutes(30);

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

            


    }
}
