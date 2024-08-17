using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetSubFeature()
        {
            return Ok(await _mediator.Send(new GetSubFeatureQuery()));
        }
        [HttpGet("[Action]/{Id}")]
        public async Task<IActionResult> GetByIdSubFeature(int Id)
        {
            return Ok(await _mediator.Send(new GetByIdSubFeatureQuery(Id)));
        }
    }
}
