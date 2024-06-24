using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult UILayout()
        {
            return View();
        }
    }
}
