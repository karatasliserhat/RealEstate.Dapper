using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutCompaniesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
