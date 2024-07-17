using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetEmployeeNameByMaxProductCountQueryHandler : IRequestHandler<GetEmployeeNameByMaxProductCountQuery, GetEmployeeNameByMaxProductCountQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetEmployeeNameByMaxProductCountQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetEmployeeNameByMaxProductCountQueryResult> Handle(GetEmployeeNameByMaxProductCountQuery request, CancellationToken cancellationToken)
        {
            return new GetEmployeeNameByMaxProductCountQueryResult { EmployeeName = await _statisticsRepository.EmployeeNameByMaxProductCount() };
        }
    }
}
