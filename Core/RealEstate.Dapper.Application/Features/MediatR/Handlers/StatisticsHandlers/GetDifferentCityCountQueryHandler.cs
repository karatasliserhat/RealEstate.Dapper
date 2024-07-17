using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetDifferentCityCountQueryHandler : IRequestHandler<GetDifferentCityCountQuery, GetDifferentCityCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetDifferentCityCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetDifferentCityCountQueryResult> Handle(GetDifferentCityCountQuery request, CancellationToken cancellationToken)
        {
            return new GetDifferentCityCountQueryResult { Count = await _statisticsRepository.DifferentCityCount() };
        }
    }
}
