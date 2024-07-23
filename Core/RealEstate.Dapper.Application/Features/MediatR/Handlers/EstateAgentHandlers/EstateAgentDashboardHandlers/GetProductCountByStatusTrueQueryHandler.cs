using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentQueries;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentResults;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.EstateAgentHandlers.EstateAgentDashboardHandlers
{
    public class GetProductCountByStatusTrueQueryHandler : IRequestHandler<GetProductCountByStatusTrueQuery, GetProductCountByStatusTrueQueryResult>
    {
        private readonly IEstateAgentDashboardRepository _estateAgentDashboardRepository;

        public GetProductCountByStatusTrueQueryHandler(IEstateAgentDashboardRepository estateAgentDashboardRepository)
        {
            _estateAgentDashboardRepository = estateAgentDashboardRepository;
        }

        public async Task<GetProductCountByStatusTrueQueryResult> Handle(GetProductCountByStatusTrueQuery request, CancellationToken cancellationToken)
        {
            return new GetProductCountByStatusTrueQueryResult { Count = await _estateAgentDashboardRepository.ProductCountByStatusTrueAsync(request.EmployeeId) };
        }
    }
}

