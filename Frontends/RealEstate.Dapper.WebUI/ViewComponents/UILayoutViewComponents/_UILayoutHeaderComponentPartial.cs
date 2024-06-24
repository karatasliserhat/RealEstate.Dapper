using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
