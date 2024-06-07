using X.Application.Request.Category;
using X.Application.ViewModel.Category;
using X.Application.ViewModel.Common;

namespace X.WebAPI.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<ApiResult<List<CategoryViewModel>>> GetAll();

        Task<ApiResult<CategoryViewModel>> GetById(Guid id);

        Task<ApiResult<string>> Create(CategoryRequest request);

        Task<ApiResult<string>> Update(Guid id, CategoryRequest request);

        Task<ApiResult<string>> UpdateParen(Guid id, Guid parentId);

        Task<ApiResult<string>> Delete(Guid id);
    }
}