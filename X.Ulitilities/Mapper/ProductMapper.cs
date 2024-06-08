using AutoMapper;
using X.Application.ViewModel.Product;
using X.Data.Entities;

namespace X.Ulitilities.Mapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductViewModel>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode))
                   .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                     .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                      .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.Material))
                       .ForMember(dest => dest.Usage, opt => opt.MapFrom(src => src.Usage));
        }

        public void ProductDetailMapper()
        {
            CreateMap<ProductDetail, ProductDetailViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Size))
                .ForMember(dest => dest.ColorId, opt => opt.MapFrom(src => src.ColorId))
                .ForMember(dest => dest.QuanitySold, opt => opt.MapFrom(src => src.QuanitySold))
                .ForMember(dest => dest.QuanityRemaining, opt => opt.MapFrom(src => src.QuanityRemaining));
        }
    }
}