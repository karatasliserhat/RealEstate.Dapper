using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public ProductDetailsController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetProductAndDetailList()
        {

            return Ok(await _mediatr.Send(new GetProductAndDetailListQuery()));
        }
        [HttpGet("[Action]/{productId}")]
        public async Task<IActionResult> GetProductDetailAndByProductId(int productId)
        {

            return Ok(await _mediatr.Send(new GetProductAndDetailByProductIdQuery(productId)));
        }
    }

}
