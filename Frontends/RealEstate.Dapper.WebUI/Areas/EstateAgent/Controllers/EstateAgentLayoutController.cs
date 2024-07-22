using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    [Route("EstateAgent/[Controller]/[Action]")]
    public class EstateAgentLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
