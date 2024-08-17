using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutNewsComponentPartial : ViewComponent
    {
        private readonly IProductReadApiService _productReadRepository;

        public _UILayoutNewsComponentPartial(IProductReadApiService productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _productReadRepository.GetListLastProductAsync(3));
        }
    }
}
