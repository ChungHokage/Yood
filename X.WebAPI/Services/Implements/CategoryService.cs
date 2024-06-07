using AutoMapper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using X.Application.Request.Category;
using X.Application.ViewModel.Category;
using X.Application.ViewModel.Common;
using X.Data.EF;
using X.Data.Entities;
using X.WebAPI.Services.Interfaces;

namespace X.WebAPI.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        private readonly XDbContext _context;
        private readonly IMapper _mapper;

        public CategoryService(
            XDbContext context,
            IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<string>> Create(CategoryRequest request)
        {
            if (request == null)
            {
                return new ApiErrorResult<string>("Request is null");
            }
            try
            {
                var category = new Category()
                {
                    Name = request.Name,
                    SeoTitle = request.SeoTitle,
                    SeoAlias = request.SeoAlias,
                    SeoDescription = request.SeoDescription,
                };
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<string>("Create new category successful");
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }

        public async Task<ApiResult<string>> Delete(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) { return new ApiErrorResult<string>($"Cannot find the category with Id:{id}"); }
            else
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<string>($"Delete the category with Id:{id} successful");
            }
        }

        public async Task<ApiResult<List<CategoryViewModel>>> GetAll()
        {
            var listCategory = await _context.Categories.ToListAsync();
            var listCateVM = new List<CategoryViewModel>();
            foreach (var c in listCategory)
            {
                var cateVM = _mapper.Map<CategoryViewModel>(c);
                listCateVM.Add(cateVM);
            }
            return new ApiSuccessResult<List<CategoryViewModel>>(listCateVM, "Get all successful");
        }

        public async Task<ApiResult<CategoryViewModel>> GetById(Guid id)
        {
            var cate = await _context.Categories.FindAsync(id);
            if (cate == null) { return new ApiErrorResult<CategoryViewModel>($"Cannot find the category with Id: {id}"); }
            else
            {
                var cateVM = _mapper.Map<CategoryViewModel>(cate);
                return new ApiSuccessResult<CategoryViewModel>(cateVM, $"Get the category with Id:{id} successful");
            }
        }

        public async Task<ApiResult<string>> Update(Guid id, CategoryRequest request)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) { return new ApiErrorResult<string>($"Cannot find the category with Id: {id}"); }
            else
            {
                category.Name = request.Name;
                category.SeoTitle = request.SeoTitle;
                category.SeoAlias = request.SeoAlias;
                category.SeoDescription = request.SeoDescription;

                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<string>("Update successful");
            }
        }

        public async Task<ApiResult<string>> UpdateParen(Guid id, Guid parentId)
        {
            var cate = await _context.Categories.FindAsync(id);
            if (cate == null) { return new ApiErrorResult<string>($"Cannot find the category with Id: {id}"); }
            else
            {
                cate.ParentId = parentId;

                _context.Categories.Update(cate);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<string>("Update parentId successful");
            }
        }
    }
}