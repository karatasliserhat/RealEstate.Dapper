using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
