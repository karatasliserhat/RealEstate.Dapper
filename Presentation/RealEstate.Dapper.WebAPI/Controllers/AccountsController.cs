using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Model;
using RealEstate.Dapper.WebAPI.Tools;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly JwtTokenGenerator _jwtGenerator;
        private readonly IMapper _mapper;
        public AccountsController(IMediator mediator, JwtTokenGenerator jwtGenerator, IMapper mapper)
        {
            _mediator = mediator;
            _jwtGenerator = jwtGenerator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(LoginUserModel loginUserModel)
        {
            var values = await _mediator.Send(new LoginUserQuery(loginUserModel));
            if (values != null)
            {
                var tokenResponse = _jwtGenerator.GeneratorToken(_mapper.Map<GetCheckUserModel>(values));

                return Ok(tokenResponse);
            }
            return Ok("Başarısız Giriş");
        }
    }
}
