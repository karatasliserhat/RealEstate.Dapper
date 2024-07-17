using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetCategoryCountQueryHandler : IRequestHandler<GetCategoryCountQuery, GetCategoryCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetCategoryCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetCategoryCountQueryResult> Handle(GetCategoryCountQuery request, CancellationToken cancellationToken)
        {
            return new GetCategoryCountQueryResult { Count = await _statisticsRepository.CategoryCount() };
        }
    }
}
