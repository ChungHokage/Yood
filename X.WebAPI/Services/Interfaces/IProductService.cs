using X.Application.Request.Product;
using X.Application.ViewModel.Common;

namespace X.WebAPI.Services.Interfaces
{
    public interface IProductService
    {
        Task<ApiResult<string>> CreateProduct(ProductRequest request);

        Task<ApiResult<string>> UpdateProduct(Guid id, ProductUpdateRequest request);

        Task<ApiResult<string>> DeleteProduct(Guid id);
    }
}