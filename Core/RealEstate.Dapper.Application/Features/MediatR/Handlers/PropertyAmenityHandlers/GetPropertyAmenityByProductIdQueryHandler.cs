using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.PropertyAmenityHandlers
{
    public class GetPropertyAmenityByProductIdQueryHandler : IRequestHandler<GetPropertyAmenityByProductIdQuery, List<GetPropertyAmenityByProductIdQueryResult>>
    {
        private readonly IProperyAmenityRepository _repository;

        public GetPropertyAmenityByProductIdQueryHandler(IProperyAmenityRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPropertyAmenityByProductIdQueryResult>> Handle(GetPropertyAmenityByProductIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetPropertyAmenityByProductIdAsync(request.ProductId);
        }
    }
}
