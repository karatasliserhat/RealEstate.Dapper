using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.PropertyAmenityHandlers
{
    internal class GetPropertyAmenityByProductIdStatusTrueQueryHandler : IRequestHandler<GetPropertyAmenityByProductIdStatusTrueQuery, List<GetPropertyAmenityByProductIdStatusTrueQueryResult>>
    {
        private readonly IProperyAmenityRepository _repository;

        public GetPropertyAmenityByProductIdStatusTrueQueryHandler(IProperyAmenityRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPropertyAmenityByProductIdStatusTrueQueryResult>> Handle(GetPropertyAmenityByProductIdStatusTrueQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetPropertyAmenityByProductIdStatusTrueAsync(request.ProductId);
        }
    }
}
