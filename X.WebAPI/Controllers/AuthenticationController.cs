using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using X.Data.Entities;
using X.WebAPI.Services.Interfaces;

namespace X.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthService _authen;
        private readonly RoleManager<AppRole> _roleManager;

        public AuthenticationController(RoleManager<AppRole> roleManager, IAuthService authen)
        {
            _roleManager = roleManager;
            _authen = authen;
        }

        [HttpPost]
        public void CreateRole([FromQuery] string roleName)
        {
            _authen.CreateRole(roleName);
        }
    }
}