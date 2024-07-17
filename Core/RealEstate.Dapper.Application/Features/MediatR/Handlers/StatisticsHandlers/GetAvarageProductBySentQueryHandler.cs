using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetAvarageProductBySentQueryHandler : IRequestHandler<GetAvarageProductBySentQuery, GetAvarageProductBySentQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetAvarageProductBySentQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetAvarageProductBySentQueryResult> Handle(GetAvarageProductBySentQuery request, CancellationToken cancellationToken)
        {
            return new GetAvarageProductBySentQueryResult { AvarageProductSent = await _statisticsRepository.AvarageProductBySent() };
        }
    }
}
