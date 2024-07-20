using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class UpdateToDoListCommand:IRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
