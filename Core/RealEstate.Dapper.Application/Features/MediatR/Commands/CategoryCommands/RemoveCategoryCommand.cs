using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class RemoveCategoryCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }

    }
}
