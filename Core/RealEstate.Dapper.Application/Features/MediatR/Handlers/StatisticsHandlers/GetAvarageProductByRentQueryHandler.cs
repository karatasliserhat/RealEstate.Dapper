using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetAvarageProductByRentQueryHandler : IRequestHandler<GetAvarageProductByRentQuery, GetAvarageProductByRentQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetAvarageProductByRentQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetAvarageProductByRentQueryResult> Handle(GetAvarageProductByRentQuery request, CancellationToken cancellationToken)
        {
            return new GetAvarageProductByRentQueryResult { AvarageProductRent = await _statisticsRepository.AvarageProductByRent() };
        }
    }
}
