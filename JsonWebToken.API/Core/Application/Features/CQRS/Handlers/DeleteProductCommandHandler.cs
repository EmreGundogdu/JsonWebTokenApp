using JsonWebToken.API.Core.Application.Features.CQRS.Commands;
using JsonWebToken.API.Core.Application.Interfaces;
using JsonWebToken.API.Core.Domain;
using MediatR;

namespace JsonWebToken.API.Core.Application.Features.CQRS.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        readonly IRepository<Product> _repository;

        public DeleteProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await _repository.GetByIdAsync(request.Id);
            if (deletedEntity is not null)
            {
                await _repository.RemoveAsync(deletedEntity);
            }
            return Unit.Value;
        }
    }
}
