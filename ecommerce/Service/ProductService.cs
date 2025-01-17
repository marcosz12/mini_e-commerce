using ecommerce.Data;
using ecommerce.Models.Product;

namespace ecommerce.Service
{
    public class ProductService
    {
        private readonly EcommerceContext _context;
        public ProductService(EcommerceContext context)
        {
            _context = context;
        }

        public List<Product> FindAll()
        {
            return _context.Products.ToList();
        }

        public void Insert(Product products)
        {
            _context.Add(products);
            _context.SaveChanges();
        }
    }
}
