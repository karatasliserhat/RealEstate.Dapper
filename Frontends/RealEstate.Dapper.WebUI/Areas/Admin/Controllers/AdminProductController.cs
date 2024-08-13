using AutoMapper;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;
using RealEstate.Dapper.ViewModel.ViewModels;
using RealEstate.Dapper.WebUI.Tools;

namespace RealEstate.Dapper.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminProductController : Controller
    {
        private readonly IProductReadApiService _productReadApiService;
        private readonly IProductCommandApiService _productCommandApiService;
        private readonly IDataProtector _dataProtector;
        private readonly IMapper _mapper;
        private readonly GetAppUserAndCategorySelectList _employeeAndCategorySelectList;
        public AdminProductController(IProductReadApiService productReadApiService, IProductCommandApiService productCommandApiService, IDataProtectionProvider dataProtectProvider, IMapper mapper, GetAppUserAndCategorySelectList employeeAndCategorySelectList)
        {
            _dataProtector = dataProtectProvider.CreateProtector("AdminProductController");
            _productReadApiService = productReadApiService;
            _productCommandApiService = productCommandApiService;
            _mapper = mapper;
            _employeeAndCategorySelectList = employeeAndCategorySelectList;
        }


        public async Task<IActionResult> Index()
        {
            var result = await _productReadApiService.GetListProductWithCategoryAndEmployeeAsync();
            result.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var values=await _employeeAndCategorySelectList.EmployeeAndCategorySelectList();
            ViewBag.CategoryList = values.CategoryList;
            ViewBag.EmployeeSelectList = values.AppUserList;
            return View(new CreateProductViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductViewModel createProductViewModel)
        {
            createProductViewModel.DealOfTheDay = false;
            var result = await _productCommandApiService.CreateAsync(createProductViewModel);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            var values =await _employeeAndCategorySelectList.EmployeeAndCategorySelectList();
            ViewBag.CategoryList = values.CategoryList;
            ViewBag.EmployeeSelectList = values.AppUserList;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(string dataId)
        {
            var dataValues = int.Parse(_dataProtector.Unprotect(dataId));
            var value = await _productReadApiService.GetByIdAsync("GetProductById", dataValues);
            if (value is not null)
            {
                var values =await _employeeAndCategorySelectList.EmployeeAndCategorySelectList(value.CategoryId, value.AppUserId);
                ViewBag.CategoryList = values.CategoryList;
                ViewBag.EmployeeSelectList = values.AppUserList;
                return View(_mapper.Map<UpdateProductViewModel>(value));
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductViewModel updateProductViewModel)
        {
            var value = await _productReadApiService.GetByIdAsync("GetProductById", updateProductViewModel.Id);
            var result = await _productCommandApiService.UpdateAsync(updateProductViewModel);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            var values =await _employeeAndCategorySelectList.EmployeeAndCategorySelectList(value.CategoryId, value.AppUserId);
            ViewBag.CategoryList = values.CategoryList;
            ViewBag.EmployeeSelectList = values.AppUserList;
            return View();
        }
        public async Task<IActionResult> Delete(string dataId)
        {
            var dataValue = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _productCommandApiService.DeleteAsync(dataValue);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> DealOfTheDayTrue(string dataId)
        {
            var dataValue = int.Parse(_dataProtector.Unprotect(dataId));
            var result =await _productCommandApiService.DealOfTheDayTrue(dataValue);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> DealOfTheDayFalse(string dataId)
        {
            var dataValue = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _productCommandApiService.DealOfTheDayFalse(dataValue);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
