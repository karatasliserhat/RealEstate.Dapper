namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetStepsGridByIdQueryResult
    {
        public int Id { get; set; }
        public string IconUrl { get; set; }
        public string Title { get; set; }
        public string Descripiton { get; set; }
        public bool Status { get; set; }
    }
}
