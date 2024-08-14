using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetPropertyAmenityByProductIdStatusTrueQuery:IRequest<List<GetPropertyAmenityByProductIdStatusTrueQueryResult>>
    {
        public int ProductId { get; set; }

        public GetPropertyAmenityByProductIdStatusTrueQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
