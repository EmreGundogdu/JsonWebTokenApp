using AutoMapper;
using JsonWebToken.API.Core.Application.DTO;
using JsonWebToken.API.Core.Domain;

namespace JsonWebToken.API.Core.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
