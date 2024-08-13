using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetListLastProductWithCategoryAndAppUserQuery:IRequest<List<GetListProductWithCategoryAndAppUserQueryResult>>
    {
        public int HowProductCount { get; set; }

        public GetListLastProductWithCategoryAndAppUserQuery(int howProductCount)
        {
            HowProductCount = howProductCount;
        }
    }
}
