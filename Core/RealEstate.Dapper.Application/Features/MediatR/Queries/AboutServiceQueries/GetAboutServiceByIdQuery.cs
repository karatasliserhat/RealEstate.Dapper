using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetAboutServiceByIdQuery:IRequest<GetAboutServiceByIdQueryResult>
    {
        public int Id { get; set; }
        public GetAboutServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
