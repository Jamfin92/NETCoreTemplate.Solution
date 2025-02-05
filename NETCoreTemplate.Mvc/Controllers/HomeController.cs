using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NETCoreTemplate.Mvc.Models;

namespace NETCoreTemplate.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
