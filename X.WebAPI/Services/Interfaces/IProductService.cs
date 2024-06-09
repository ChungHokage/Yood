using X.Application.Request.Product;
using X.Application.ViewModel.Common;
using X.Application.ViewModel.Product;
using X.Data.Entities;

namespace X.WebAPI.Services.Interfaces
{
    public interface IProductService
    {
        Task<ApiResult<string>> CreateProduct(ProductRequest request);

        Task<ApiResult<string>> CreateProductDetails(Guid productId, ProductDetailRequest request);

        Task<ApiResult<string>> UpdateProduct(Guid id, ProductUpdateRequest request);

        Task<ApiResult<string>> DeleteProduct(Guid id);

        Task<ApiResult<ProductViewModel>> GetById(Guid id);

        Task<ApiResult<List<ProductViewModel>>> GetAll();

        Task<ApiResult<ProductDetailViewModel>> GetDetailsById(Guid id);

        Task<ApiResult<List<ProductDetailViewModel>>> GetAllDetailsForProduct(Guid productId);

        Task<ApiResult<string>> CreateColor(ColorRequest request);

        Task<ApiResult<List<Color>>> GetAllColor();

        Task<ApiResult<Color>> GetById(string id);

        Task<ApiResult<bool>> AssignCategory();
    }
}