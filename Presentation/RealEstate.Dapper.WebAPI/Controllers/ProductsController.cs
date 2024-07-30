using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetListProductWithCategoryAndEmplooye()
        {
            return Ok(await _mediator.Send(new GetListProductWithCategoryAndEmployeeQuery()));
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            return Ok(await _mediator.Send(new GetProductByIdQuery(id)));
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetListProductByUser(int id)
        {
            return Ok(await _mediator.Send(new GetListProductByUserQuery(id)));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> DealOfTheDayTrue(int id)
        {
            await _mediator.Send(new DealOfTheDayTrueCommand(id));
            return Ok("Günün Fırsatı Aktif Edildi");
        }
        [HttpGet("[Action]/{HowProductCount}")]
        public async Task<IActionResult> GetListLastProduct(int HowProductCount)
        {
            return Ok(await _mediator.Send(new GetListLastProductWithCategoryAndEmployeeQuery(HowProductCount)));
        }
        [HttpGet("[Action]/{HowProductCount}/{UserId}")]
        public async Task<IActionResult> GetListLastProduct(int HowProductCount, int UserId)
        {
            return Ok(await _mediator.Send(new GetListLastProductWithCategoryAndEmployeeByUserIdQuery(UserId, HowProductCount)));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> DealOfTheDayFalse(int id)
        {
            await _mediator.Send(new DealOfTheDayFalseCommand(id));
            return Ok("Günün Fırsatı Pasif Edildi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByIdWithCategoryAndEmployee(int id)
        {
            return Ok(await _mediator.Send(new GetProductByIdWithCategoryAndEmployeeQuery(id)));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return Ok($"{id} li Ürün Silinmiştir");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand updateProductCommand)
        {
            await _mediator.Send(updateProductCommand);
            return Ok("Ürün Güncellemesi Yapıldı");
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand createProductCommand)
        {
            await _mediator.Send(createProductCommand);
            return Created();
        }
    }
}
