using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategoryAll()
        {
            return Ok(await _mediator.Send(new GetCategoryQuery()));
        }
        [HttpGet("[action]/id")]
        public async Task<IActionResult> GetCategory(int id)
        {
            return Ok(await _mediator.Send(new GetCategoryByIdQuery(id)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand createCategoryCommand)
        {
            await _mediator.Send(createCategoryCommand);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand updateCategoryCommand)
        {
            await _mediator.Send(updateCategoryCommand);
            return Ok("Kategori Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _mediator.Send(new RemoveCategoryCommand(id));
            return Ok($"{id} li Kategori Silindi");
        }
    }
}
