namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class LoginUserQueryResult
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool IsExist { get; set; }
    }
}
