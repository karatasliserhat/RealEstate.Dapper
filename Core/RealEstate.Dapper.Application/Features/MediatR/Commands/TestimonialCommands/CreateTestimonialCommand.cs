using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class CreateTestimonialCommand:IRequest
    {
        public string NameSurname { get; set; }
        public string Comment { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}
