using Microsoft.AspNetCore.Mvc;
using NETCoreTemplate.Mvc.Models;

namespace NETCoreTemplate.Mvc.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View(new FormViewModel());
        }

        [HttpPost]
        public IActionResult Index(FormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Process the form data here
            // Redirect to success page or show success message
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}