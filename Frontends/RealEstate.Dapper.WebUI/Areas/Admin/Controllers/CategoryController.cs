using AutoMapper;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryReadApiService _categoryReadApiService;
        private readonly ICategoryCommandApiService _categoryCommandApiService;
        private readonly IDataProtector _dataProtector;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryReadApiService categoryReadApiService, IDataProtectionProvider _dataProtectProvider, ICategoryCommandApiService categoryCommandApiService, IMapper mapper)
        {
            _dataProtector = _dataProtectProvider.CreateProtector("CategoryController");
            _categoryReadApiService = categoryReadApiService;
            _categoryCommandApiService = categoryCommandApiService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _categoryReadApiService.GetListAsync();
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(values);
        }
        public IActionResult Create()
        {
            return View(new CreateCategoryViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryViewModel createCategoryViewModel)
        {
            var response = await _categoryCommandApiService.CreateAsync(createCategoryViewModel);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string dataId)
        {
            var dataValueId = int.Parse(_dataProtector.Unprotect(dataId));
            var values = await _categoryReadApiService.GetByIdAsync(dataValueId);
            var data = _mapper.Map<UpdateCategoryViewModel>(values);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryViewModel updateCategoryViewModel)
        {
            var response = await _categoryCommandApiService.UpdateAsync(updateCategoryViewModel);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string dataId)
        {
            var dataValueId = int.Parse(_dataProtector.Unprotect(dataId));
            var response = await _categoryCommandApiService.DeleteAsync(dataValueId);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
