using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Entities;

namespace WebApplication4.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsByKeyAsync(string key = "");
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductById(int id);

        Task AddAsync(Product product);
        Task DeleteAsync(Product product);
        Task UpdateAsync(Product product);

    }
}
