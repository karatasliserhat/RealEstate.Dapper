using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsesController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public StatisticsesController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetActiveCategoryCount()
        {
            return Ok(await _mediatR.Send(new GetActiveCategoryCountQuery()));
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetActiveEmployeeCount()
        {
            return Ok(await _mediatR.Send(new GetActiveEmployeeCountQuery()));
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetApartmentCount()
        {
            return Ok(await _mediatR.Send(new GetAparmentCountQuery()));
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAvarageProductByRent()
        {
            return Ok(await _mediatR.Send(new GetAvarageProductByRentQuery()));
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAvarageProductBySent()
        {
            return Ok(await _mediatR.Send(new GetAvarageProductBySentQuery()));
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAvarageRoomCount()
        {
            return Ok(await _mediatR.Send(new GetAvarageRoomCountQuery()));
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetCategoryCount()
        {
            return Ok(await _mediatR.Send(new GetCategoryCountQuery()));
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetCategoryNameByMaxProductCount()
        {
            return Ok(await _mediatR.Send(new GetCategoryNameByMaxProductCountQuery()));
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetCityNameByMaxProductCount()
        {
            return Ok(await _mediatR.Send(new GetCityNameByMaxProductCountQuery()));
        }
        
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetDifferentCityCount()
        {
            return Ok(await _mediatR.Send(new GetDifferentCityCountQuery()));
        }
        
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetEmployeeNameByMaxProductCount()
        {
            return Ok(await _mediatR.Send(new GetEmployeeNameByMaxProductCountQuery()));
        }
        
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetLastProductPrice()
        {
            return Ok(await _mediatR.Send(new GetLastProductPriceQuery()));
        }
        
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetNewestBuildingYear()
        {
            return Ok(await _mediatR.Send(new GetNewestBuildingYearQuery()));
        }
        
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetOldestBuildingYear()
        {
            return Ok(await _mediatR.Send(new GetOldestBuildingYearQuery()));
        }
        
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetPassiveCategoryCount()
        {
            return Ok(await _mediatR.Send(new GetPassiveCategoryCountQuery()));
        } 
        
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetProductCount()
        {
            return Ok(await _mediatR.Send(new GetProductCountQuery()));
        }
    }
}
