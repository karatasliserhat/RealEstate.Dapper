using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemoveEmployeeCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveEmployeeCommand(int id)
        {
            Id = id;
        }
    }
}
