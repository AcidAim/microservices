using Catalog.api.Entities;

namespace Catalog.api.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProducts();
    
    Task<Product> GetProduct(string id);
    
    Task<IEnumerable<Product>> GetProductByName(string name);
    
    Task<IEnumerable<Product>> GetProductByCategory(string catergoryName);
    
    Task CreateProduct(Product product);
    
    Task<bool> UpdateProduct(Product product);
    
    Task<bool> DeleteProduct(string id);
}