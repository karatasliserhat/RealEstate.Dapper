using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetProductByIdWithCategoryAndEmployeeQuery:IRequest<GetProductByIdWithCategoryAndEmployeeQueryResult>
    {
        public int Id { get; set; }

        public GetProductByIdWithCategoryAndEmployeeQuery(int id)
        {
            Id = id;
        }
    }
}
