using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetByIdAboutDetailQuery:IRequest<GetByIdAboutDetailQueryResult>
    {
        public int Id { get; set; }
        public GetByIdAboutDetailQuery(int id)
        {
            Id = id;
        }
    }
}
