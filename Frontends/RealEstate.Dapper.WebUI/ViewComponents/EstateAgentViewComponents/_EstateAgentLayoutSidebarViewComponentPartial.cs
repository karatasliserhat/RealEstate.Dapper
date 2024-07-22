using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _EstateAgentLayoutSidebarViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
