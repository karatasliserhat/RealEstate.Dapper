using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentResults;

namespace RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentQueries
{
    public class GetProductCountByEmployeeIdQuery:IRequest<GetProductCountByEmployeeIdQueryResult>
    {
        public int EmployeeId { get; set; }

        public GetProductCountByEmployeeIdQuery(int employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}
