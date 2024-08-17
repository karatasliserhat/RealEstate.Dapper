using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.SubFeatureHandlers
{
    public class GetSubFeatureQueryHandler : IRequestHandler<GetSubFeatureQuery, List<GetSubFeatureQueryResults>>
    {
        private readonly ISubFeatureRepository _subFeatureRepository;

        public GetSubFeatureQueryHandler(ISubFeatureRepository subFeatureRepository)
        {
            _subFeatureRepository = subFeatureRepository;
        }

        public async Task<List<GetSubFeatureQueryResults>> Handle(GetSubFeatureQuery request, CancellationToken cancellationToken)
        {
            return await _subFeatureRepository.GetSubFeatureListAsync();
        }
    }
}
