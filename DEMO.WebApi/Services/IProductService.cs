using DEMO.WebApi.Models;

namespace DEMO.WebApi.Services
{
    public interface IProductService
    {
        void CreateProduct(ProductModel product);
        void DeleteProduct(Guid id);
        List<Product> GetAllProducts();
        Product GetProductById(Guid id);
    }
}