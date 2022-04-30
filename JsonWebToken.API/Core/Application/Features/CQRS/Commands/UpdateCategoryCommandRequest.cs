using MediatR;

namespace JsonWebToken.API.Core.Application.Features.CQRS.Commands
{
    public class UpdateCategoryCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string? Definition { get; set; }

        public UpdateCategoryCommandRequest(int id, string? definition)
        {
            Id = id;
            Definition = definition;
        }
    }
}
