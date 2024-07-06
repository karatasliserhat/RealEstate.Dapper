using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetPopulerLocationByIdQuery:IRequest<GetPopulerLocationByIdQueryResult>
    {
        public int Id { get; set; }
        public GetPopulerLocationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
