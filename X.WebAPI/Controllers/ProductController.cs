using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using X.Application.Request.Product;
using X.WebAPI.Services.Interfaces;

namespace X.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("add-product")]
        public async Task<IActionResult> Add([FromBody] ProductRequest request)
        {
            var result = await _productService.CreateProduct(request);
            if (result.isSuccessed) { return Ok(result); }
            else { return BadRequest(result.Message); }
        }

        [HttpPost("add-color")]
        public async Task<IActionResult> AddColor([FromBody] ColorRequest request)
        {
            var result = await _productService.CreateColor(request);
            if (result.isSuccessed) { return Ok(result); }
            else { return BadRequest(result.Message); }
        }

        [HttpPost("add-details")]
        public async Task<IActionResult> AddDetails(Guid productId, ProductDetailRequest request)
        {
            var result = await _productService.CreateProductDetails(productId, request);
            if (result.isSuccessed) { return Ok(result); }
            else { return BadRequest(result.Message); }
        }
    }
}