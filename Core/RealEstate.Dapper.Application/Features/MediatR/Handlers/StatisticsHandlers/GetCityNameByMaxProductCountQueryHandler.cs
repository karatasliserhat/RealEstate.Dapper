using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetCityNameByMaxProductCountQueryHandler : IRequestHandler<GetCityNameByMaxProductCountQuery, GetCityNameByMaxProductCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetCityNameByMaxProductCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetCityNameByMaxProductCountQueryResult> Handle(GetCityNameByMaxProductCountQuery request, CancellationToken cancellationToken)
        {
            return new GetCityNameByMaxProductCountQueryResult { CityName = await _statisticsRepository.CityNameByMaxProductCount() };
        }
    }
}
