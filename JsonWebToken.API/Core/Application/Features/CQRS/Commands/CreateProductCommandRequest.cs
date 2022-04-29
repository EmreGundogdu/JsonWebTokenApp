using MediatR;

namespace JsonWebToken.API.Core.Application.Features.CQRS.Commands
{
    public class CreateProductCommandRequest : IRequest
    {
        public string? Name { get; set; }
        public int Stcok { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
