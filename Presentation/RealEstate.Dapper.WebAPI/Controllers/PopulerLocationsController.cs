using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopulerLocationsController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public PopulerLocationsController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<IActionResult> GetPopulerLocation()
        {
            return Ok(await _mediatr.Send(new GetPopulerLocationQuery()));
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetPopulerLocationById(int id)
        {
            return Ok(await _mediatr.Send(new GetPopulerLocationByIdQuery(id)));
        }
        [HttpPost]
        public async Task<IActionResult> CreatePopulerLocation(CreatePopulerLocationCommand createPopulerLocationCommand)
        {
            await _mediatr.Send(createPopulerLocationCommand);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePopulerLocation(UpdatePopulerLocationCommand updatePopulerLocationCommand)
        {
            await _mediatr.Send(updatePopulerLocationCommand);
            return Ok("Popüler Lokasyon Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopulerLocatin(int id)
        {
            await _mediatr.Send(new RemovePopulerLocationCommand(id));
            return Ok($"{id} li Popüler Lokasyon Silindi");
        }
    }

}
