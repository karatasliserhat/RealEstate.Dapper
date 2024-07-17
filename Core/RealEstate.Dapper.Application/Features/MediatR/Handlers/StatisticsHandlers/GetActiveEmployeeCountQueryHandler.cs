using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetActiveEmployeeCountQueryHandler : IRequestHandler<GetActiveEmployeeCountQuery, GetActiveCategoryCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetActiveEmployeeCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetActiveCategoryCountQueryResult> Handle(GetActiveEmployeeCountQuery request, CancellationToken cancellationToken)
        {
            return new GetActiveCategoryCountQueryResult { Count = await _statisticsRepository.ActiveEmployeeCount() };
        }
    }
}
