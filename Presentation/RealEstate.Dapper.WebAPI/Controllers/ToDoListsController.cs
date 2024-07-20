using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ToDoListsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetToDoListAll()
        {
            return Ok(await _mediator.Send(new GetToDoListQuery()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDoList(int id)
        {
            return Ok(await _mediator.Send(new GetToDoListByIdQuery(id)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateToDoList(CreateToDoListCommand createToDoListCommand)
        {
            await _mediator.Send(createToDoListCommand);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateToDoList(UpdateToDoListCommand updateToDoListCommand)
        {
            await _mediator.Send(updateToDoListCommand);
            return Ok("İş Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoList(int id)
        {
            await _mediator.Send(new RemoveToDoListCommand(id));
            return Ok($"{id} li İş Silindi");
        }
    }
}
