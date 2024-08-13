using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;
using RealEstate.Dapper.Shared.Abstract.IUserServices;
using RealEstate.Dapper.ViewModel.ViewModels;
using RealEstate.Dapper.WebUI.Tools;

namespace RealEstate.Dapper.WebUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    [Route("EstateAgent/[Controller]/[Action]")]
    [Authorize]
    public class EstateAgentMyAdsController : Controller
    {
        private readonly IProductReadApiService _productReadApiService;
        private readonly IProductCommandApiService _productCommandApiService;
        private readonly GetAppUserAndCategorySelectList _employeeAndCategorySelectList;
        private readonly IUserService _userService;
        public EstateAgentMyAdsController(IProductReadApiService productReadApiService, IUserService userService, IProductCommandApiService productCommandApiService, GetAppUserAndCategorySelectList employeeAndCategorySelectList)
        {
            _productReadApiService = productReadApiService;
            _userService = userService;
            _productCommandApiService = productCommandApiService;
            _employeeAndCategorySelectList = employeeAndCategorySelectList;
        }

        public async Task<IActionResult> AdvertsTrue()
        {
            int id = int.Parse(_userService.GetUser);
            var values = await _productReadApiService.GetListProductByUserAsync(id, true);
            return View(values);
        }
        public async Task<IActionResult> AdvertsFalse()
        {
            int id = int.Parse(_userService.GetUser);
            var values = await _productReadApiService.GetListProductByUserAsync(id, false);
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {

            var values = await _employeeAndCategorySelectList.EmployeeAndCategorySelectList();
            ViewBag.CategoryList = values.CategoryList;
            return View(new CreateProductViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductViewModel createProductViewModel)
        {
            createProductViewModel.AppUserId = int.Parse(_userService.GetUser);
            createProductViewModel.DealOfTheDay = false;
            var result = await _productCommandApiService.CreateAsync(createProductViewModel);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(AdvertsTrue));
            }

            var values = await _employeeAndCategorySelectList.EmployeeAndCategorySelectList();
            ViewBag.CategoryList = values.CategoryList;
            return View();
        }
    }
}
