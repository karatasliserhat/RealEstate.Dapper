using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetAparmentCountQueryHandler : IRequestHandler<GetAparmentCountQuery, GetAparmentCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetAparmentCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetAparmentCountQueryResult> Handle(GetAparmentCountQuery request, CancellationToken cancellationToken)
        {
            return new GetAparmentCountQueryResult { Count = await _statisticsRepository.ApartmentCount() };
        }
    }
}
