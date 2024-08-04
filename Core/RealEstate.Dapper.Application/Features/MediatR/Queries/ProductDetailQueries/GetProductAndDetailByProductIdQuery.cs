using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetProductAndDetailByProductIdQuery:IRequest<GetProductAndDetailByProductIdQueryResult>
    {
        public int ProductId { get; set; }

        public GetProductAndDetailByProductIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
