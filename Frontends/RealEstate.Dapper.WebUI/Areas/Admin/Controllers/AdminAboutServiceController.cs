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
    public class AdminAboutServiceController : Controller
    {
        private readonly IDataProtector _dataProtector;
        private readonly IAboutServiceReadApiService _aboutServiceReadApi;
        private readonly IAboutServiceCommandApiService _aboutServiceCommandApi;
        private readonly IMapper _mapper;
        public AdminAboutServiceController(IAboutServiceReadApiService aboutServiceReadApiService, IDataProtectionProvider dataProvider, IAboutServiceCommandApiService aboutServiceCommandApiService, IMapper mapper)
        {
            _dataProtector = dataProvider.CreateProtector("AdminAboutService");
            _aboutServiceReadApi = aboutServiceReadApiService;
            _aboutServiceCommandApi = aboutServiceCommandApiService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _aboutServiceReadApi.GetListAsync();
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(values);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateAboutServiceViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutServiceViewModel createAboutServiceViewModel)
        {
            var response = await _aboutServiceCommandApi.CreateAsync(createAboutServiceViewModel);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(string dataId)
        {
            var dataValue = int.Parse(_dataProtector.Unprotect(dataId));

            return View(_mapper.Map<UpdateAboutServiceViewModel>(await _aboutServiceReadApi.GetByIdAsync(dataValue)));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateAboutServiceViewModel updateAboutServiceViewModel)
        {
            var response = await _aboutServiceCommandApi.UpdateAsync(updateAboutServiceViewModel);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        public async Task<IActionResult> Delete(string dataId)
        {
            var dataValue = int.Parse(_dataProtector.Unprotect(dataId));
            var response = await _aboutServiceCommandApi.DeleteAsync(dataValue);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));

            }
            return View();
        }
    }
}
