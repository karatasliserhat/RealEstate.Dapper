using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemoveContactCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveContactCommand(int id)
        {
            Id = id;
        }
    }
}
