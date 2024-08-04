using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[Action]/{productId}")]
        public async Task<IActionResult> GetProductImageListByProductId(int productId)
        {
            return Ok(await _mediator.Send(new GetProductImageQuery(productId)));
        }
    }
}
