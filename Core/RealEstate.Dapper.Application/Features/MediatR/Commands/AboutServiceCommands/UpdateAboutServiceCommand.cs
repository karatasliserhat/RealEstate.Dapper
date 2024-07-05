using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class UpdateAboutServiceCommand:IRequest
    {
        public int Id { get; set; }
        public string AboutServiceName { get; set; }
        public bool AboutServiceStatus { get; set; }
    }
}
