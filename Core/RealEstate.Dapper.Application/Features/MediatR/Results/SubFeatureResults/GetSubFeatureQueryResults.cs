namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetSubFeatureQueryResults
    {
        public int Id { get; set; }
        public string IconUrl { get; set; }
        public string TopTitle { get; set; }
        public string MainTitle { get; set; }
        public string Descripiton { get; set; }
        public string SubTitle { get; set; }
        public bool Status { get; set; }
    }
}
