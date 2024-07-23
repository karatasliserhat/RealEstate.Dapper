using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentQueries;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentResults;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.EstateAgentHandlers.EstateAgentDashboardHandlers
{
    public class GetProductCountByStatusFalseQueryHandler : IRequestHandler<GetProductCountByStatusFalseQuery, GetProductCountByStatusFalseQueryResult>
    {
        private readonly IEstateAgentDashboardRepository _estateAgentDashboardRepository;

        public GetProductCountByStatusFalseQueryHandler(IEstateAgentDashboardRepository estateAgentDashboardRepository)
        {
            _estateAgentDashboardRepository = estateAgentDashboardRepository;
        }

        public async Task<GetProductCountByStatusFalseQueryResult> Handle(GetProductCountByStatusFalseQuery request, CancellationToken cancellationToken)
        {
            return new GetProductCountByStatusFalseQueryResult { Count = await _estateAgentDashboardRepository.ProductCountByStatusFalseAsync(request.EmployeeId) };
        }
    }
}
