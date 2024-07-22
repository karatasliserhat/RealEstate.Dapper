using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RealEstate.Dapper.WebAPI.Tools
{
    public class JwtTokenGenerator
    {
        private readonly IJwtTokenModel _jwtTokenModel;

        public JwtTokenGenerator(IJwtTokenModel jwtTokenModel)
        {
            _jwtTokenModel = jwtTokenModel;
        }

        public TokenResponeModel GeneratorToken(GetCheckUserModel model)
        {

            var claims = new List<Claim>();
            if (!string.IsNullOrWhiteSpace(model.RoleName))
            {
                claims.Add(new Claim(ClaimTypes.Role, model.RoleName));
            }
            if (!string.IsNullOrEmpty(model.UserName))
            {
                claims.Add(new Claim("Username", model.UserName));
            }
            if (!string.IsNullOrEmpty(model.Name))
            {
                claims.Add(new Claim(ClaimTypes.Name, model.Name));
            }
            if (!string.IsNullOrEmpty(model.Email))
            {
                claims.Add(new Claim(ClaimTypes.Email, model.Email));
            }
            claims.Add(new Claim(ClaimTypes.NameIdentifier, model.UserId.ToString()));

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtTokenModel.Key));
            var signInCredential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var ExpireDate = DateTime.UtcNow.AddDays(_jwtTokenModel.ExpireDate);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: _jwtTokenModel.Issuer, audience: _jwtTokenModel.Audience, claims: claims, notBefore: DateTime.UtcNow, expires: ExpireDate, signingCredentials: signInCredential);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return new TokenResponeModel(handler.WriteToken(jwtSecurityToken), ExpireDate);
        }
    }
}
