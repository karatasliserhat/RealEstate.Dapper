using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetStepsGridByIdQuery : IRequest<GetStepsGridByIdQueryResult>
    {
        public int Id { get; set; }
        public GetStepsGridByIdQuery(int id)
        {
            Id = id;
        }
    }
}
