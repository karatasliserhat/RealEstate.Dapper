namespace RealEstate.Dapper.WebAPI.Tools
{
    public class TokenResponeModel
    {
        public TokenResponeModel(string token, DateTime expireDate)
        {
            Token = token;
            ExpireDate = expireDate;
        }

        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
