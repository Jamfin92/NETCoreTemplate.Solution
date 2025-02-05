using Microsoft.AspNetCore.Mvc;

namespace NETCoreTemplate.Mvc.Controllers
{
    public class GridController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
