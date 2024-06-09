using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using X.Application.Request.Account;
using X.Application.ViewModel.Common;
using X.Data.EF;
using X.Data.Entities;
using X.Ulitilities.Common;
using X.WebAPI.Services.Interfaces;

namespace X.WebAPI.Services.Implements
{
    public class AuthService : IAuthService
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _config;
        private readonly UserManager<AppUser> _userManager;
        private readonly XDbContext _context;
        //      private readonly IEmailSender<MailContent> _emailSender;

        public AuthService(UserManager<AppUser> userManager,
          SignInManager<AppUser> signInManager,
          RoleManager<AppRole> roleManager,
          IConfiguration config,
          XDbContext context
          /*IEmailSender<MailContent> emailSender*/
          )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _context = context;
            //  _emailSender = emailSender;
        }

        public async Task<ApiResult<string>> CreateRole(string roleName)
        {
            var newRole = new AppRole()
            {
                Name = roleName
            };
            var role = await _roleManager.CreateAsync(newRole);
            if (role == null)
            {
                return new ApiErrorResult<string>("Error occured.. please try again");
            }
            else return new ApiSuccessResult<string>("The role was created");
        }

        public async Task<ApiResult<string>> Login(LoginRequest request)
        {
            if (request == null)
                return new ApiErrorResult<string>("Login container is empty");

            var getUser = await _userManager.FindByNameAsync(request.Username);
            if (getUser is null)
                return new ApiErrorResult<string>("User not found");

            bool checkUserPasswords = await _userManager.CheckPasswordAsync(getUser, request.Password);
            if (!checkUserPasswords)
                return new ApiErrorResult<string>("Invalid email/password");

            var getUserRole = await _userManager.GetRolesAsync(getUser);
            var userSession = new UserSession(getUser.Id, getUser.UserName, getUser.Email, getUserRole.First());
            string token = GenerateToken(userSession);
            return new ApiSuccessResult<string>(token, "Login completed");
        }

        public async Task<ApiResult<string>> RegisterAsync(RegisterRequest request)
        {
            if (request is null) return new ApiErrorResult<string>("Model is empty");

            var newUser = new AppUser()
            {
                PasswordHash = request.Password,
                UserName = request.UserName,
                Email = request.Email,
            };
            var user = await _userManager.FindByEmailAsync(newUser.Email);

            if (user is not null) return new ApiErrorResult<string>("User registered already");
            //validate email register

            var createUser = await _userManager.CreateAsync(newUser!, request.Password);
            if (!createUser.Succeeded) return new ApiErrorResult<string>("Error occured.. please try again");
            await _userManager.AddToRoleAsync(newUser, "User");
            return new ApiSuccessResult<string>("Account Created");
        }

        public void VerifyEmail(string email, string requestCode)
        {
            Random random = new Random();
            var verifyCode = random.Next(0, 9999);
            SendEmailVerify(email);
            if (requestCode.Equals(verifyCode))
            {
            }
        }

        private void SendEmailVerify(string email)
        {
            Random random = new Random();
            var verifyCode = random.Next(0, 9999);
            var mailContet = new MailContent()
            {
                To = email,
                Subject = "Mã xác minh của bạn là: " + verifyCode,
                Body = "<p>Mã xác minh của bạn là" + verifyCode + "</p>"
            };
        }

        private string GenerateToken(UserSession user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var userClaims = new[]
            {
                  new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()!),
                  new Claim(ClaimTypes.Name, user.Name!),
               //   new Claim(ClaimTypes.Email, user.Email!),
                  new Claim(ClaimTypes.Role, user.Role)
              };
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: userClaims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public Task<ApiResult<string>> Logout()
        {
            throw new NotImplementedException();
        }
    }
}