using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetCategoryNameByMaxProductCountQueryHandler : IRequestHandler<GetCategoryNameByMaxProductCountQuery, GetCategoryNameByMaxProductCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetCategoryNameByMaxProductCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetCategoryNameByMaxProductCountQueryResult> Handle(GetCategoryNameByMaxProductCountQuery request, CancellationToken cancellationToken)
        {
            return new GetCategoryNameByMaxProductCountQueryResult { CategoryName = await _statisticsRepository.CategoryNameByMaxProductCount() };
        }
    }
}
