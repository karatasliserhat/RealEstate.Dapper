using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemoveAboutDetailCommand:IRequest
    {
        public int Id { get; set; }
        public RemoveAboutDetailCommand(int id)
        {
            Id = id;
        }
    }
}
