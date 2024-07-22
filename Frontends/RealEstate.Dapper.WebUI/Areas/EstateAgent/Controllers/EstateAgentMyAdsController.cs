using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;

namespace RealEstate.Dapper.WebUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    [Route("EstateAgent/[Controller]/[Action]")]
    [Authorize]
    public class EstateAgentMyAdsController : Controller
    {
        private readonly IProductReadApiService _productReadApiService;

        public EstateAgentMyAdsController(IProductReadApiService productReadApiService)
        {
            _productReadApiService = productReadApiService;
        }

        public async Task<IActionResult> Index()
        {
            int id = 3;
            var values = await _productReadApiService.GetListProductByUserAsync(id);
            return View(values);
        }
    }
}
