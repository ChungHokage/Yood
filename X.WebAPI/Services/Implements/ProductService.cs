using AutoMapper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using X.Application.Request.Product;
using X.Application.ViewModel.Common;
using X.Application.ViewModel.Product;
using X.Data.EF;
using X.Data.Entities;
using X.Ulitilities.Shared;
using X.WebAPI.Services.Interfaces;

namespace X.WebAPI.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly XDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(
            XDbContext context,
            IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ApiResult<bool>> AssignCategory()
        {
            throw new NotImplementedException();
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

        public async Task<ApiResult<List<ProductViewModel>>> GetAll()
        {
            var listProduct = await _context.Products.ToListAsync();
            var listProductVM = new List<ProductViewModel>();
            foreach (var p in listProduct)
            {
                var product = _mapper.Map<ProductViewModel>(p);
                listProductVM.Add(product);
            }
            return new ApiSuccessResult<List<ProductViewModel>>(listProductVM, "Get all product successful");
        }

        public async Task<ApiResult<List<Color>>> GetAllColor()
        {
            var listColor = await _context.Colors.ToListAsync();
            return new ApiSuccessResult<List<Color>>(listColor, "Get all color successful");
        }

        public async Task<ApiResult<List<ProductDetailViewModel>>> GetAllDetailsForProduct(Guid productId)
        {
            var resutl = await _context.ProductDetail.Where(x => x.ProductId == productId).ToListAsync();
            if (resutl == null) return new ApiErrorResult<List<ProductDetailViewModel>>("Can not find");
            else
            {
                var listProductDetailVM = new List<ProductDetailViewModel>();
                foreach (var pd in resutl)
                {
                    var productDetail = _mapper.Map<ProductDetailViewModel>(pd);
                    listProductDetailVM.Add(productDetail);
                }
                return new ApiSuccessResult<List<ProductDetailViewModel>>(listProductDetailVM, "Get all detail for product success");
            }
        }

        public async Task<ApiResult<ProductViewModel>> GetById(Guid id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return new ApiErrorResult<ProductViewModel>($"Cannot find the product with Id: {id}");
            }
            else
            {
                var productVM = _mapper.Map<ProductViewModel>(product);
                return new ApiSuccessResult<ProductViewModel>(productVM, "Get the product successful");
            }
        }

        public async Task<ApiResult<Color>> GetById(string id)
        {
            var color = await _context.Colors.FindAsync(id);
            if (color == null) return new ApiErrorResult<Color>($"Cannot find the color with Id: {id}");
            else
            {
                return new ApiSuccessResult<Color>(color, "Get successful");
            }
        }

        public Task<ApiResult<ProductDetailViewModel>> GetDetailsById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> UpdateProduct(Guid id, ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}