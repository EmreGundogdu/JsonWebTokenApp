using JsonWebToken.API.Core.Application.Enums;
using JsonWebToken.API.Core.Application.Features.CQRS.Commands;
using JsonWebToken.API.Core.Application.Interfaces;
using JsonWebToken.API.Core.Domain;
using MediatR;

namespace JsonWebToken.API.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        readonly IRepository<AppUser> _repository;

        public RegisterUserCommandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                AppRoleId = (int)RoleType.Member,
                Password = request.Password,
                Username = request.Username,
            });
            return Unit.Value;
        }
    }
}
