namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetProductImageQueryResult
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
    }
}
