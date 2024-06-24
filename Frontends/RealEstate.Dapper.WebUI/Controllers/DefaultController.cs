using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
