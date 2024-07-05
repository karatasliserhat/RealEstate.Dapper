using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemoveAboutServiceCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveAboutServiceCommand(int id)
        {
            Id = id;
        }
    }
}
