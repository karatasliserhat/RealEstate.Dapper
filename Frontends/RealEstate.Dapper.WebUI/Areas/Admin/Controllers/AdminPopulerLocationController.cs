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
    public class AdminPopulerLocationController : Controller
    {
        private readonly IDataProtector _dataProtector;
        private readonly IPopulerLocationCommandApiService _opulerLocationCommandApiService;
        private readonly IPopulerLocationReadApiService _opulerLocationReadApiService;
        private readonly IMapper _mapper;
        public AdminPopulerLocationController(IDataProtectionProvider dataProvider, IMapper mapper, IPopulerLocationCommandApiService opulerLocationCommandApiService, IPopulerLocationReadApiService opulerLocationReadApiService)
        {
            _dataProtector = dataProvider.CreateProtector("AdminPopulerLocation");
            _mapper = mapper;
            _opulerLocationCommandApiService = opulerLocationCommandApiService;
            _opulerLocationReadApiService = opulerLocationReadApiService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _opulerLocationReadApiService.GetListAsync();
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(values);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePopulerLocationViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePopulerLocationViewModel createPopulerLocation)
        {
            var response = await _opulerLocationCommandApiService.CreateAsync(createPopulerLocation);
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

            return View(_mapper.Map<UpdatePopulerLocationViewModel>(await _opulerLocationReadApiService.GetByIdAsync(dataValue)));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdatePopulerLocationViewModel updatePopulerLocation)
        {
            var response = await _opulerLocationCommandApiService.UpdateAsync(updatePopulerLocation);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        public async Task<IActionResult> Delete(string dataId)
        {
            var dataValue = int.Parse(_dataProtector.Unprotect(dataId));
            var response = await _opulerLocationCommandApiService.DeleteAsync(dataValue);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));

            }
            return View();
        }
    }
}
