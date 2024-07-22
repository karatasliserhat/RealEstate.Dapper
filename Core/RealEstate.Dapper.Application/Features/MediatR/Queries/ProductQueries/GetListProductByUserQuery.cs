using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetListProductByUserQuery:IRequest<List<GetListProductByUserQueryResult>>
    {
        public int EmployeeId { get; set; }

        public GetListProductByUserQuery(int employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}
