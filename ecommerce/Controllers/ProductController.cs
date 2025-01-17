using ecommerce.Models.Product;
using ecommerce.Service;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service;

        public ProductController(ProductService productService)
        {
            _service = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = _service.FindAll();
            return View(    );
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _service.Insert(product);
            return RedirectToAction(nameof(Index));

        }
    }
}
