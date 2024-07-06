using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemoveTestimonialCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveTestimonialCommand(int id)
        {
            Id = id;

        }
    }
}
