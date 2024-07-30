using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetInBoxMessageQuery:IRequest<List<GetInBoxMessageQueryResult>>
    {
        public int ReceiveId { get; set; }
        public int HowCount { get; set; }
        public GetInBoxMessageQuery(int receiveId, int howCount)
        {
            ReceiveId = receiveId;
            HowCount = howCount;
        }
    }
}
