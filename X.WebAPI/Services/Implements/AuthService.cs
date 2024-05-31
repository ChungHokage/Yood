using Microsoft.AspNetCore.Identity;
using X.Data.Entities;
using X.WebAPI.Services.Interfaces;

namespace X.WebAPI.Services.Implements
{
    public class AuthService : IAuthService
    {
        private readonly RoleManager<AppRole> _roleManager;

        public AuthService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public string CreateRole(string roleName)
        {
            var newRole = new AppRole()
            {
                Name = roleName,
            };
            _roleManager.CreateAsync(newRole);
            return "Create new role successful";
        }
    }
}