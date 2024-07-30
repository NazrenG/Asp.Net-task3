using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Entities;
using WebApplication4.Repositories;

namespace WebApplication4.Services
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductServices(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task DeleteAsync(Product product)
        {
            await _repository.DeleteAsync(product);
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            return _repository.GetAllProducts();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _repository.GetProductById(id);
        }

        async Task IProductService.UpdateAsync(Product product)
        {
            await _repository.UpdateAsync(product);
        }

        async Task IProductService.AddAsync(Product product)
        {
            await _repository.AddAsync(product);
        }

        async Task<List<Product>> IProductService.GetProductsByKeyAsync(string key)
        {
            return await _repository.GetAllProduct(key);
        }
    }
}
