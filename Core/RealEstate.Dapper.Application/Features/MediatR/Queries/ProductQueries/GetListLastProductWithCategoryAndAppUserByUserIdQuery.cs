using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetListLastProductWithCategoryAndAppUserByUserIdQuery:IRequest<List<GetListProductWithCategoryAndAppUserQueryResult>>
    {
        public int HowCount { get; set; }
        public int UserId { get; set; }

        public GetListLastProductWithCategoryAndAppUserByUserIdQuery(int userId, int howCount)
        {
            UserId = userId;
            HowCount = howCount;
        }
    }
}
