using Microsoft.AspNetCore.Mvc;
using NETCoreTemplate.Mvc.Factories;
using NETCoreTemplate.Mvc.Models.Documents;

namespace NETCoreTemplate.Mvc.Controllers
{
    public class FactoryPatternController : Controller
    {
        private readonly IDocumentFactory _documentFactory;

        public FactoryPatternController(IDocumentFactory documentFactory)
        {
            _documentFactory = documentFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessDocument(string documentType, string content)
        {
            try
            {
                IDocument document = _documentFactory.CreateDocument(documentType);
                document.Content = content;
                ViewBag.Result = document.Process();
                ViewBag.Success = true;
            }
            catch (ArgumentException ex)
            {
                ViewBag.Result = ex.Message;
                ViewBag.Success = false;
            }

            return View("Index");
        }
    }
} 