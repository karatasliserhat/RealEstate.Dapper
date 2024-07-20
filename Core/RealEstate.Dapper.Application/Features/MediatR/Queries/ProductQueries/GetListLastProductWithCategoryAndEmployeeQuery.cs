using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetListLastProductWithCategoryAndEmployeeQuery:IRequest<List<GetListProductWithCategoryAndEmployeeQueryResult>>
    {
        public int HowProductCount { get; set; }

        public GetListLastProductWithCategoryAndEmployeeQuery(int howProductCount)
        {
            HowProductCount = howProductCount;
        }
    }
}
