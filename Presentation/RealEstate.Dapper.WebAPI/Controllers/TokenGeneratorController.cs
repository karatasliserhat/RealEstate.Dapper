using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.WebAPI.Tools;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenGeneratorController : ControllerBase
    {
        private readonly JwtTokenGenerator _jwtGenerator;

        public TokenGeneratorController(JwtTokenGenerator jwtGenerator)
        {
            _jwtGenerator = jwtGenerator;
        }

        [HttpPost]
        public IActionResult GenerateToken(GetCheckUserModel model)
        {
            var responseToken = _jwtGenerator.GeneratorToken(model);
            return Ok(responseToken);
        }
    }
}
