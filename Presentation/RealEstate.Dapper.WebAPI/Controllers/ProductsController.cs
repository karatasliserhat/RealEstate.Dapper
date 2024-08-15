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
            return Ok(await _mediator.Send(new GetListProductWithCategoryAndAppUserQuery()));
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            return Ok(await _mediator.Send(new GetProductByIdQuery(id)));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetListProductByDealOfTheDayQuery()
        {
            return Ok(await _mediator.Send(new GetListProductByDealOfTheDayQuery()));
        }
        [HttpGet("[action]/{id}/{status}")]
        public async Task<IActionResult> GetListProductByUserAndTrueOrFalse(int id, bool status)
        {
            return Ok(await _mediator.Send(new GetListProductByUserQuery(id, status)));
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
            return Ok(await _mediator.Send(new GetListLastProductWithCategoryAndAppUserQuery(HowProductCount)));
        }
        [HttpGet("[Action]/{HowProductCount}/{UserId}")]
        public async Task<IActionResult> GetListLastProduct(int HowProductCount, int UserId)
        {
            return Ok(await _mediator.Send(new GetListLastProductWithCategoryAndAppUserByUserIdQuery(UserId, HowProductCount)));
        }
        [HttpGet("[Action]/{SearchKeyValue}/{CategoryId}/{City}")]
        public async Task<IActionResult> GetProductListBySearchQuery(string SearchKeyValue, int CategoryId, string City)
        {
            return Ok(await _mediator.Send(new GetProductListBySearchQuery(SearchKeyValue, CategoryId, City)));
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
            return Ok(await _mediator.Send(new GetProductByIdWithCategoryAndAppUserQuery(id)));
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
