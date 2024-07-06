using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class CreateStepsGridCommand:IRequest
    {
        public string IconUrl { get; set; }
        public string Title { get; set; }
        public string Descripiton { get; set; }
        public bool Status { get; set; }
    }
}
