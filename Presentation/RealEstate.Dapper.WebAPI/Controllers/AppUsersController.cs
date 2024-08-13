using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAppUserList()
        {
            return Ok(await _mediator.Send(new GetAppUserQuery()));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetAppUserById(int id)
        {
            return Ok(await _mediator.Send(new GetAppUserByIdQuery(id)));
        }
    }
}
