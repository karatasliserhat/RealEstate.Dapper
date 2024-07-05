using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutServicesController(IMediator mediatR)
        {
            _mediator = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutServiceAll()
        {
            return Ok(await _mediator.Send(new GetAboutServiceQeury()));
        }
        [HttpGet("[action]/id")]
        public async Task<IActionResult> GetAboutService(int id)
        {
            return Ok(await _mediator.Send(new GetAboutServiceByIdQuery(id)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutService(CreateAboutServiceCommand createAboutServiceCommand)
        {
            await _mediator.Send(createAboutServiceCommand);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAboutService(UpdateAboutServiceCommand updateAboutServiceCommand)
        {
            await _mediator.Send(updateAboutServiceCommand);
            return Ok("Hizmetlerimiz Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutService(int id)
        {
            await _mediator.Send(new RemoveAboutServiceCommand(id));
            return Ok($"{id} li Hizmet Silindi");
        }
    }
}
