namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetToDoListQueryResult
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
