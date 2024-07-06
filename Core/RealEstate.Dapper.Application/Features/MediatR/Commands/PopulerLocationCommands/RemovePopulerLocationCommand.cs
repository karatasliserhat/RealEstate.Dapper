using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemovePopulerLocationCommand:IRequest
    {
        public int Id { get; set; }
        public RemovePopulerLocationCommand(int id)
        {
            Id = id;
        }
    }
}
