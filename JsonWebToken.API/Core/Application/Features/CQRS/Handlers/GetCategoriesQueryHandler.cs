using AutoMapper;
using JsonWebToken.API.Core.Application.DTO;
using JsonWebToken.API.Core.Application.Features.CQRS.Queries;
using JsonWebToken.API.Core.Application.Interfaces;
using JsonWebToken.API.Core.Domain;
using MediatR;
using System.Collections.Generic;

namespace JsonWebToken.API.Core.Application.Features.CQRS.Handlers
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQueryRequest, List<CategoryListDto>>
    {
        readonly IRepository<Category> _repository;
        readonly IMapper _mapper;
        public GetCategoriesQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto>> Handle(GetCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            return _mapper.Map<List<CategoryListDto>>(data);
        }
    }
}
