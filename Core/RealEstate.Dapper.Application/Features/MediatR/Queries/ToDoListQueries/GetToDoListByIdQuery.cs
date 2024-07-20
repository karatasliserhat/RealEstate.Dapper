using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetToDoListByIdQuery:IRequest<GetToDoListByIdQueryResult>
    {
        public int Id { get; set; }

        public GetToDoListByIdQuery(int id)
        {
            Id = id;
        }
    }
}
