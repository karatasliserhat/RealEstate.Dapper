using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetTestimonialByIdQuery:IRequest<GetTestimonialByIdQueryResult>
    {
        public int Id { get; set; }
        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }
    }
}
