using ecommerce.Data;
using ecommerce.Models.Product;
using ecommerce.Service.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Service
{
    public class ProductService
    {
        private readonly EcommerceContext _context;
        public ProductService(EcommerceContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> FindAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task InsertAsync(Product products)
        {
            _context.Add(products);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Products.FindAsync();
                _context.Products.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new IntegrityException(ex.Message);
            }
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _context
                .Products
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
