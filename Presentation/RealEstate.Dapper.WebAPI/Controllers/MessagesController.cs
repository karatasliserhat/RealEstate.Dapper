using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[Action]/{ReceiveId}/{HowProductCount}")]
        public async Task<IActionResult> GetInBoxMessage(int ReceiveId, int HowProductCount)
        {
            return Ok(await _mediator.Send(new GetInBoxMessageQuery(ReceiveId, HowProductCount)));
        }
    }
}
