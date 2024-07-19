using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class DealOfTheDayFalseCommand:IRequest
    {
        public int Id { get; set; }

        public DealOfTheDayFalseCommand(int id)
        {
            Id = id;
        }
    }
}
