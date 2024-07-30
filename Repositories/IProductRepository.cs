using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Entities;

namespace WebApplication4.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProduct(string key ="");
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task AddAsync(Product product);
        Task DeleteAsync(Product product);
        Task UpdateAsync(Product product);
    }
}
