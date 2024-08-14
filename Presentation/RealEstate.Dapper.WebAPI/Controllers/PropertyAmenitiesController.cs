using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAmenitiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PropertyAmenitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[Action]/{ProductId}")]
        public async Task<IActionResult> GetProperyAmenityByProductId(int ProductId)
        {
            return Ok(await _mediator.Send(new GetPropertyAmenityByProductIdQuery(ProductId)));
        }
        [HttpGet("[Action]/{ProductId}")]
        public async Task<IActionResult> GetProperyAmenityByProductIdStatusFalse(int ProductId)
        {
            return Ok(await _mediator.Send(new GetPropertyAmenityByProductIdStatusFalseQuery(ProductId)));
        }
        [HttpGet("[Action]/{ProductId}")]
        public async Task<IActionResult> GetProperyAmenityByProductIdStatusTrue(int ProductId)
        {
            return Ok(await _mediator.Send(new GetPropertyAmenityByProductIdStatusTrueQuery(ProductId)));
        }
    }
}
