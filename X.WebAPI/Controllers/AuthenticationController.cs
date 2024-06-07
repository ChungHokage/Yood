using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using X.Application.Request.Account;
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

        [HttpPost("createRole")]
        public async Task<IActionResult> CreateRole([FromQuery] string roleName)
        {
            var response = await _authen.CreateRole(roleName);

            if (!response.isSuccessed)
            {
                return BadRequest(response);
            }
            else
            {
                return Ok(response);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _authen.Login(request);
            if (!result.isSuccessed)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var result = await _authen.RegisterAsync(request);
            if (!result.isSuccessed)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }
    }
}