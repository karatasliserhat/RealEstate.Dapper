using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetPropertyAmenityByProductIdQuery:IRequest<List<GetPropertyAmenityByProductIdQueryResult>>
    {
        public int ProductId { get; set; }

        public GetPropertyAmenityByProductIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
