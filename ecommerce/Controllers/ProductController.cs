using ecommerce.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new() { Id = 1, Name = "adsfafs", Description = "asdasdad", ImageUrl = "afdasa", Price = 1234, Stock = 6}
            };


            return View(products);
        }
    }
}
