namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetCategoryQueryResult
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
