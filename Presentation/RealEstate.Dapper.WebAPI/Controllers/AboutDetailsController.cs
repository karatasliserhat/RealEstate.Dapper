using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAboutDetailAll()
        {
            return Ok(await _mediator.Send(new GetAboutDetailQuery()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutDetail(int id)
        {
            return Ok(await _mediator.Send(new GetByIdAboutDetailQuery(id)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutDetail(CreateAboutDetailCommand createAboutDetailCommand)
        {
            await _mediator.Send(createAboutDetailCommand);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAboutDetail(UpdateAboutDetailCommand updateAboutDetailCommand)
        {
            await _mediator.Send(updateAboutDetailCommand);
            return Ok("Hakkımızda Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutDetail(int id)
        {
            await _mediator.Send(new RemoveAboutDetailCommand(id));
            return Ok($"{id} li Hakkımızda Silindi");
        }
    }
}
