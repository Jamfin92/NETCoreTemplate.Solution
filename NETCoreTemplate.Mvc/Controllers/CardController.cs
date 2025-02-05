using Microsoft.AspNetCore.Mvc;

namespace NETCoreTemplate.Mvc.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
} 