using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class CreateCategoryCommand:IRequest
    {
        public string CategoryName { get; set; }
        public bool Status { get; set; }

    }
}
