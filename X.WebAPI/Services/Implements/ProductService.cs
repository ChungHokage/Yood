using Azure.Core;
using X.Application.Request.Product;
using X.Application.ViewModel.Common;
using X.Data.EF;
using X.Data.Entities;
using X.Ulitilities.Shared;
using X.WebAPI.Services.Interfaces;

namespace X.WebAPI.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly XDbContext _context;

        public ProductService(XDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<string>> CreateColor(ColorRequest request)
        {
            if (request == null) { return new ApiErrorResult<string>("Request is null"); }
            else
            {
                var color = new Color()
                {
                    Id = GenarateCode.ColorCode(),
                    Name = request.Name,
                    RGB = request.RGB,
                };
                await _context.Colors.AddAsync(color);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<string>("Create new color successful");
            }
        }

        public async Task<ApiResult<string>> CreateProduct(ProductRequest request)
        {
            if (request == null) return new ApiErrorResult<string>($"Request is null");
            else
            {
                try
                {
                    var product = new Product()
                    {
                        Name = request.Name,
                        ProductCode = GenarateCode.ProductCode(),
                        Description = request.Description,
                        Price = request.Price,
                        Material = request.Material,
                        Usage = request.Usage,
                    };
                    await _context.Products.AddAsync(product);
                    await _context.SaveChangesAsync();
                    return new ApiSuccessResult<string>("Create new product successful");
                }
                catch (Exception ex)
                {
                    return new ApiErrorResult<string>(ex.Message);
                }
            }
        }

        public async Task<ApiResult<string>> CreateProductDetails(Guid productId, ProductDetailRequest request)
        {
            if (request == null) return new ApiErrorResult<string>("Request is null");
            else
            {
                var productDetail = new ProductDetail()
                {
                    ProductId = productId,
                    Size = request.Size,
                    ColorId = request.ColorId,
                    QuanityRemaining = request.QuanityRemaining,
                    QuanitySold = request.QuanitySold,
                };
                await _context.ProductDetail.AddAsync(productDetail);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<string>("Create new product detail successful");
            }
        }

        public async Task<ApiResult<string>> DeleteProduct(Guid id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return new ApiErrorResult<string>($"Cannot find the product with Id:{id}");
            else
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<string>($"Deleted the product with Id:{id}");
            }
        }

        public Task<ApiResult<string>> UpdateProduct(Guid id, ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}