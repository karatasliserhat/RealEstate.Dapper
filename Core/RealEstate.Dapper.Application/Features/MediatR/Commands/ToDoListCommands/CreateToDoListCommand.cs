using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class CreateToDoListCommand:IRequest
    {
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
