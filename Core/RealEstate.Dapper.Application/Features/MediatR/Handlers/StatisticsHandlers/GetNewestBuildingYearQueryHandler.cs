using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetNewestBuildingYearQueryHandler : IRequestHandler<GetNewestBuildingYearQuery, GetNewestBuildingYearQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetNewestBuildingYearQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }
        public async Task<GetNewestBuildingYearQueryResult> Handle(GetNewestBuildingYearQuery request, CancellationToken cancellationToken)
        {
            return new GetNewestBuildingYearQueryResult { BuildingYear = await _statisticsRepository.NewestBuildingYear() };
        }
    }
}
