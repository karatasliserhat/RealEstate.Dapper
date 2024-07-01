namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetAboutDetailQueryResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
    }
}
