using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetPropertyAmenityByProductIdStatusFalseQuery:IRequest<List<GetPropertyAmenityByProductIdStatusFalseQueryResult>>
    {
        public int ProductId { get; set; }

        public GetPropertyAmenityByProductIdStatusFalseQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
