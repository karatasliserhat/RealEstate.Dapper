namespace RealEstate.Dapper.WebAPI.Tools
{
    public class GetCheckUserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool IsExist { get; set; }

    }
}
