using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetByIdSubFeatureQuery:IRequest<GetByIdSubFeatureQueryResults>
    {
        public int SubFeatureId { get; set; }

        public GetByIdSubFeatureQuery(int subFeatureId)
        {
            SubFeatureId = subFeatureId;
        }
    }
}
