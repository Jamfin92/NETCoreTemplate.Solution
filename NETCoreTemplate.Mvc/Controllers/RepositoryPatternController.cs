using Microsoft.AspNetCore.Mvc;
using NETCoreTemplate.Mvc.Services;
using NETCoreTemplate.Mvc.Models;

namespace NETCoreTemplate.Mvc.Controllers
{
    public class RepositoryPatternController : Controller
    {
        private readonly IProductService _productService;

        public RepositoryPatternController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }
    }
} 