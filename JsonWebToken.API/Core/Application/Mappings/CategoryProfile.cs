using AutoMapper;
using JsonWebToken.API.Core.Application.DTO;
using JsonWebToken.API.Core.Domain;

namespace JsonWebToken.API.Core.Application.Mappings
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
