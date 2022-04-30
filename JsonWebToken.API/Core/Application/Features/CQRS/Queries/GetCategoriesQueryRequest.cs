using JsonWebToken.API.Core.Application.DTO;
using MediatR;

namespace JsonWebToken.API.Core.Application.Features.CQRS.Queries
{
    public class GetCategoriesQueryRequest : IRequest<List<CategoryListDto>>
    {
    }
}
