using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentQueries;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentResults;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.EstateAgentHandlers.EstateAgentDashboardHandlers
{
    internal class GetProductCountByEmployeeIdQueryHandler:IRequestHandler<GetProductCountByEmployeeIdQuery, GetProductCountByEmployeeIdQueryResult>
    {
        private readonly IEstateAgentDashboardRepository _estateAgentDashboardRepository;

        public GetProductCountByEmployeeIdQueryHandler(IEstateAgentDashboardRepository estateAgentDashboardRepository)
        {
            _estateAgentDashboardRepository = estateAgentDashboardRepository;
        }

        public async Task<GetProductCountByEmployeeIdQueryResult> Handle(GetProductCountByEmployeeIdQuery request, CancellationToken cancellationToken)
        {
            return new GetProductCountByEmployeeIdQueryResult { Count = await _estateAgentDashboardRepository.ProductCountByEmployeeIdAsync(request.EmployeeId) };
        }
    }
}
