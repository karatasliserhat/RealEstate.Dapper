using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemoveStepsGridCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveStepsGridCommand(int id)
        {
            Id = id;
        }
    }
}
