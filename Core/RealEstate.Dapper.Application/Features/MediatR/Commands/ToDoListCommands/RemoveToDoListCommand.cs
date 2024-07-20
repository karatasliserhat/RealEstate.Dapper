using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemoveToDoListCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveToDoListCommand(int id)
        {
            Id = id;
        }
    }
}
