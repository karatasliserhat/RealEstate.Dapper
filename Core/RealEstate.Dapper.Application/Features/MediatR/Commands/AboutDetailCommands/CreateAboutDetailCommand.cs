using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class CreateAboutDetailCommand:IRequest
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
    }
}
