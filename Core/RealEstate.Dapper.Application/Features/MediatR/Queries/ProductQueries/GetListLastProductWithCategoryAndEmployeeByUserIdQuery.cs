using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetListLastProductWithCategoryAndEmployeeByUserIdQuery:IRequest<List<GetListProductWithCategoryAndEmployeeQueryResult>>
    {
        public int HowCount { get; set; }
        public int UserId { get; set; }

        public GetListLastProductWithCategoryAndEmployeeByUserIdQuery(int userId, int howCount)
        {
            UserId = userId;
            HowCount = howCount;
        }
    }
}
