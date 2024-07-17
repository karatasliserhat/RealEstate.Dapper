using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetActiveCategoryCountQueryHandler : IRequestHandler<GetActiveCategoryCountQuery, GetActiveCategoryCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetActiveCategoryCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetActiveCategoryCountQueryResult> Handle(GetActiveCategoryCountQuery request, CancellationToken cancellationToken)
        {
            var result= await _statisticsRepository.ActiveCategoryCount();
            return new GetActiveCategoryCountQueryResult { Count = result };
        }
    }
}
