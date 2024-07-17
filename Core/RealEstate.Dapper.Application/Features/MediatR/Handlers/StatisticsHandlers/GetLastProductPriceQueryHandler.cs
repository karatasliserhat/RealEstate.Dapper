using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetLastProductPriceQueryHandler : IRequestHandler<GetLastProductPriceQuery, GetLastProductPriceQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetLastProductPriceQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetLastProductPriceQueryResult> Handle(GetLastProductPriceQuery request, CancellationToken cancellationToken)
        {
            return new GetLastProductPriceQueryResult { LastPrice = await _statisticsRepository.LastProductPrice() };
        }
    }
}
