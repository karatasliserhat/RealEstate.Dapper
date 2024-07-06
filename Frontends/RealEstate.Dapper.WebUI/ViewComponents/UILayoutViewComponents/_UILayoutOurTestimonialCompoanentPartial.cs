using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutOurTestimonialCompoanentPartial : ViewComponent
    {
        private ITestimonialReadApiService _testimonialRepository;

        public _UILayoutOurTestimonialCompoanentPartial(ITestimonialReadApiService testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _testimonialRepository.GetListAsync());
        }
    }
}
