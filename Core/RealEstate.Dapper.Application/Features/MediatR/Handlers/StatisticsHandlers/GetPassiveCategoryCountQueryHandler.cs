using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetPassiveCategoryCountQueryHandler : IRequestHandler<GetPassiveCategoryCountQuery, GetPassiveCategoryCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetPassiveCategoryCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetPassiveCategoryCountQueryResult> Handle(GetPassiveCategoryCountQuery request, CancellationToken cancellationToken)
        {
            return new GetPassiveCategoryCountQueryResult { PassiveCategoryCount = await _statisticsRepository.PassiveCategoryCount() };
        }
    }
}
