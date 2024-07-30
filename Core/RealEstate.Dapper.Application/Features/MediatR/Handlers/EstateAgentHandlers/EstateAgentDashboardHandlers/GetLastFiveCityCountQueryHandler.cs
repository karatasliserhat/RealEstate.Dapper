using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.EstateAgentHandlers.EstateAgentDashboardHandlers
{
    public class GetLastFiveCityCountQueryHandler : IRequestHandler<GetLastFiveCityCountQuery, List<GetLastFiveCityCountQueryResult>>
    {
        private readonly IEstateAgentDashboardRepository _repository;

        public GetLastFiveCityCountQueryHandler(IEstateAgentDashboardRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLastFiveCityCountQueryResult>> Handle(GetLastFiveCityCountQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetLastFiveCountCity();
        }
    }
}
