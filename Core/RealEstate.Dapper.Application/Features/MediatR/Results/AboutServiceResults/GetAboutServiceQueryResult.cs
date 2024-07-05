namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetAboutServiceQueryResult
    {
        public int Id { get; set; }
        public string AboutServiceName { get; set; }
        public bool AboutServiceStatus { get; set; }
    }
}
