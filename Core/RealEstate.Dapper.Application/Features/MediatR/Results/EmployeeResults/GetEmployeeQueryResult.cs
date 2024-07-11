namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetEmployeeQueryResult
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
