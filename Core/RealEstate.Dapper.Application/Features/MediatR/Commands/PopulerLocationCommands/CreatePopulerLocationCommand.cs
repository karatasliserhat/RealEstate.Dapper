using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class CreatePopulerLocationCommand : IRequest
    {
        public string CityName { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
