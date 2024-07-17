using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetProductCountQueryHandler : IRequestHandler<GetProductCountQuery, GetProductCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetProductCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetProductCountQueryResult> Handle(GetProductCountQuery request, CancellationToken cancellationToken)
        {
            return new GetProductCountQueryResult { Count = await _statisticsRepository.ProductCount() };
        }
    }
}
