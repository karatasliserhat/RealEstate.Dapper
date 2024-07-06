using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StepsGridsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StepsGridsController(IMediator mediatR)
        {
            _mediator = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> GetStepsGridAll()
        {
            return Ok(await _mediator.Send(new GetStepsGridQuery()));
        }
        [HttpGet("[action]/id")]
        public async Task<IActionResult> GetStepsGrid(int id)
        {
            return Ok(await _mediator.Send(new GetStepsGridByIdQuery(id)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateStepsGrid(CreateStepsGridCommand createStepsGridCommand)
        {
            await _mediator.Send(createStepsGridCommand);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStepsGrid(UpdateStepsGridCommand updateStepsGridCommand)
        {
            await _mediator.Send(updateStepsGridCommand);
            return Ok("Alan Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStepsGrid(int id)
        {
            await _mediator.Send(new RemoveStepsGridCommand(id));
            return Ok($"{id} li Alan Silindi");
        }
    }
}
