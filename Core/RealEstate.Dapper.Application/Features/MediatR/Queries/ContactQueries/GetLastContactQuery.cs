using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetLastContactQuery:IRequest<List<GetContactQueryResult>>
    {
        public int HowContactCount { get; set; }

        public GetLastContactQuery(int howContactCount)
        {
            HowContactCount = howContactCount;
        }
    }
}
