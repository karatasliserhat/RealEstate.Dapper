using MediatR;
using Microsoft.AspNetCore.Mvc;
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
    }
}
