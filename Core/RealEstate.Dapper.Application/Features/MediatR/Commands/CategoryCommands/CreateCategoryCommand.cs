using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class CreateCategoryCommand:IRequest
    {
        public string Name { get; set; }
        public bool Status { get; set; }

    }
}
