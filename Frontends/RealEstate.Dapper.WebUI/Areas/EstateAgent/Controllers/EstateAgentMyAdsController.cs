using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;
using RealEstate.Dapper.Shared.Abstract.IUserServices;

namespace RealEstate.Dapper.WebUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    [Route("EstateAgent/[Controller]/[Action]")]
    [Authorize]
    public class EstateAgentMyAdsController : Controller
    {
        private readonly IProductReadApiService _productReadApiService;
        private readonly IUserService _userService;
        public EstateAgentMyAdsController(IProductReadApiService productReadApiService, IUserService userService)
        {
            _productReadApiService = productReadApiService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            int id = int.Parse(_userService.GetUser);
            var values = await _productReadApiService.GetListProductByUserAsync(id);
            return View(values);
        }
    }
}
