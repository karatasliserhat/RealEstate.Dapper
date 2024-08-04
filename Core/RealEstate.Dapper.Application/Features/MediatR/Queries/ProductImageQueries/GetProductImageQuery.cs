using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetProductImageQuery:IRequest<List<GetProductImageQueryResult>>
    {
        public int ProductId { get; set; }

        public GetProductImageQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
