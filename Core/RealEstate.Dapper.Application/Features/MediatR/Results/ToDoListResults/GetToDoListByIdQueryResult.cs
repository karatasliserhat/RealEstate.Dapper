namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetToDoListByIdQueryResult
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
