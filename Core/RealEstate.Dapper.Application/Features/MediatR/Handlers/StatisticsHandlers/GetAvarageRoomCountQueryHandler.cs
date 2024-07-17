using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetAvarageRoomCountQueryHandler : IRequestHandler<GetAvarageRoomCountQuery, GetAvarageRoomCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetAvarageRoomCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetAvarageRoomCountQueryResult> Handle(GetAvarageRoomCountQuery request, CancellationToken cancellationToken)
        {
            return new GetAvarageRoomCountQueryResult { Count = await _statisticsRepository.AvarageRoomCount() };
        }
    }
}
