using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.PropertyAmenityHandlers
{
    internal class GetPropertyAmenityByProductIdStatusFalseQueryHandler : IRequestHandler<GetPropertyAmenityByProductIdStatusFalseQuery, List<GetPropertyAmenityByProductIdStatusFalseQueryResult>>
    {
        private readonly IProperyAmenityRepository _repository;

        public GetPropertyAmenityByProductIdStatusFalseQueryHandler(IProperyAmenityRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPropertyAmenityByProductIdStatusFalseQueryResult>> Handle(GetPropertyAmenityByProductIdStatusFalseQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetPropertyAmenityByProductIdStatusFalseAsync(request.ProductId);
        }
    }
}
