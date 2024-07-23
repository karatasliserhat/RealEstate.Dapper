using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentResults;

namespace RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentQueries
{
    public class GetProductCountByStatusFalseQuery:IRequest<GetProductCountByStatusFalseQueryResult>
    {
        public int EmployeeId { get; set; }

        public GetProductCountByStatusFalseQuery(int employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}
