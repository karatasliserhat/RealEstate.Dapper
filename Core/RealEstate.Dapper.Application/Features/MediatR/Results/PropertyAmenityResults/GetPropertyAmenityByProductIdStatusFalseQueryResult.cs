namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetPropertyAmenityByProductIdStatusFalseQueryResult
    {
        public int ProductId { get; set; }
        public int AmenityId { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}
