using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentResults;

namespace RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentQueries
{
    public class GetProductCountByStatusTrueQuery:IRequest<GetProductCountByStatusTrueQueryResult>
    {
        public int EmployeeId { get; set; }

        public GetProductCountByStatusTrueQuery(int employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}
