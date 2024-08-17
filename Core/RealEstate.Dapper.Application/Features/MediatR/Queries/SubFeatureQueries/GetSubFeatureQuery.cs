using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetSubFeatureQuery:IRequest<List<GetSubFeatureQueryResults>>
    {
    }
}
