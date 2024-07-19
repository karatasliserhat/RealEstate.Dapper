using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class DealOfTheDayTrueCommand : IRequest
    {
        public int Id { get; set; }

        public DealOfTheDayTrueCommand(int id)
        {
            Id = id;
        }
    }
}
