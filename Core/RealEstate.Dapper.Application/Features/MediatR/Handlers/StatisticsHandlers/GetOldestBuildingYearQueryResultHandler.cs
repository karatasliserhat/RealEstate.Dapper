using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetOldestBuildingYearQueryResultHandler : IRequestHandler<GetOldestBuildingYearQuery, GetOldestBuildingYearQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetOldestBuildingYearQueryResultHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetOldestBuildingYearQueryResult> Handle(GetOldestBuildingYearQuery request, CancellationToken cancellationToken)
        {
            return new GetOldestBuildingYearQueryResult { BuildingYear = await _statisticsRepository.OldestBuildingYear() };
        }
    }
}
