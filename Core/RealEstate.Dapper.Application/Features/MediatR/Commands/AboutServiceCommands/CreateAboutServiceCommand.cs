using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class CreateAboutServiceCommand:IRequest
    {
        public string AboutServiceName { get; set; }
        public bool AboutServiceStatus { get; set; }
    }
}
