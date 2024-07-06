using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class UpdatePopulerLocationCommand:IRequest
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
