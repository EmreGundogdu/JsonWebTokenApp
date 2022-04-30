using JsonWebToken.API.Core.Application.DTO;
using MediatR;

namespace JsonWebToken.API.Core.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest:IRequest<CheckUserResponseDto>
    {
        public string Username{ get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
