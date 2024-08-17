using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.SubFeatureHandlers
{
    public class GetByIdSubFeatureQueryHandler : IRequestHandler<GetByIdSubFeatureQuery, GetByIdSubFeatureQueryResults>
    {
        private readonly ISubFeatureRepository _subFeatureRepository;

        public GetByIdSubFeatureQueryHandler(ISubFeatureRepository subFeatureRepository)
        {
            _subFeatureRepository = subFeatureRepository;
        }

        public async Task<GetByIdSubFeatureQueryResults> Handle(GetByIdSubFeatureQuery request, CancellationToken cancellationToken)
        {
            return await _subFeatureRepository.GetByIdSubFeatureQueryAsync(request.SubFeatureId);
        }
    }
}
