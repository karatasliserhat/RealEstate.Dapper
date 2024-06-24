using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class UpdateCategoryCommand:IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
