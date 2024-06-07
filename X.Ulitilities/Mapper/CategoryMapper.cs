using AutoMapper;
using X.Application.ViewModel.Category;
using X.Data.Entities;

namespace X.Ulitilities.Mapper
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category, CategoryViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.ParentId))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.SeoTitle, opt => opt.MapFrom(src => src.SeoTitle))
                .ForMember(dest => dest.SeoAlias, opt => opt.MapFrom(src => src.SeoAlias))
                .ForMember(dest => dest.SeoDescription, opt => opt.MapFrom(src => src.SeoDescription))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));
        }
    }
}