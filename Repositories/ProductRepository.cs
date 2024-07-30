using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Entities;

namespace WebApplication4.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }


        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        async Task IProductRepository.AddAsync(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        async Task<List<Product>> IProductRepository.GetAllProduct(string key = "")
        {
            var keyCode = key?.Trim().ToLower();
            return keyCode != null ? await _context.Products.Where(i => i.Name == keyCode).ToListAsync() :
                await _context.Products.ToListAsync();
        }

        async Task IProductRepository.DeleteAsync(Product product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(i => i.Id == id);
        }

        async Task IProductRepository.UpdateAsync(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
