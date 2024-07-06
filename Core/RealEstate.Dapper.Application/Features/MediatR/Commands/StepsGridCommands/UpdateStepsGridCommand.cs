using MediatR;

namespace RealEstate.Dapper.Application.Features.MediatR.Commands
{
    public class UpdateStepsGridCommand:IRequest
    {
        public int Id { get; set; }
        public string IconUrl { get; set; }
        public string Title { get; set; }
        public string Descripiton { get; set; }
        public bool Status { get; set; }
    }
}
