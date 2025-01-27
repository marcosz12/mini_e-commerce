using ecommerce.Data;
using ecommerce.Models;
using ecommerce.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Data;

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

        public async Task UpdateAsync(Product products)
        {
            bool hasAny = await _context.Products.AnyAsync(x => x.Id == products.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(products);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }
        }
    }
}
