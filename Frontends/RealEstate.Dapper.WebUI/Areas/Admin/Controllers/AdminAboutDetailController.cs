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
    public class AdminAboutDetailController : Controller
    {
        private readonly IDataProtector _dataProtector;
        private readonly IAboutDetailReadApiService _aboutDetailReadApiService;
        private readonly IAboutDetailCommandApiService _aboutDetailCommandApiService;
        private readonly IMapper _mapper;
        public AdminAboutDetailController(IAboutDetailReadApiService aboutDetailReadApiService, IDataProtectionProvider dataProvider, IAboutDetailCommandApiService aboutDetailCommandApiService, IMapper mapper)
        {
            _dataProtector = dataProvider.CreateProtector("AdminAboutDetail");
            _aboutDetailReadApiService = aboutDetailReadApiService;
            _aboutDetailCommandApiService = aboutDetailCommandApiService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _aboutDetailReadApiService.GetListAsync();
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(values);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateAboutDetailViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDetailViewModel createAboutDetailViewModel)
        {
            var response = await _aboutDetailCommandApiService.CreateAsync(createAboutDetailViewModel);
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

            return View(_mapper.Map<UpdateAboutDetailViewModel>(await _aboutDetailReadApiService.GetByIdAsync(dataValue)));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateAboutDetailViewModel updateAboutDetailViewModel)
        {
            var response = await _aboutDetailCommandApiService.UpdateAsync(updateAboutDetailViewModel);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        public async Task<IActionResult> Delete(string dataId)
        {
            var dataValue = int.Parse(_dataProtector.Unprotect(dataId));
            var response = await _aboutDetailCommandApiService.DeleteAsync(dataValue);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));

            }
            return View();
        }
    }
}
