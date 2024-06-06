using X.Application.Request.Account;
using X.Application.ViewModel.Common;

namespace X.WebAPI.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ApiResult<string>> CreateRole(string roleName);

        Task<ApiResult<string>> RegisterAsync(RegisterRequest request);

        Task<ApiResult<string>> Login(LoginRequest request);
    }
}