using DEMO.WebApi.Data;
using DEMO.WebApi.Models;

namespace DEMO.WebApi.Services;

public class ProductService : IProductService
{
    private readonly DemoWebApiDbContext _context;

    /// <summary>
    /// The constructor of ProductService
    /// </summary>
    /// <param name="context"></param>
    public ProductService(DemoWebApiDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// The method to create a product
    /// </summary>
    /// <param name="product"></param>
    public void CreateProduct(Models.ProductModel product)
    {
        Product productEntity = new Product
        {
            Id = Guid.NewGuid(),
            Name = product.Name,
            Description = product.Description,
            Stock = product.Stock,
            Price = product.Price,
            CreatedAt = DateTime.Now
        };
        _context.Products.Add(productEntity);
        _context.SaveChanges();
    }

    /// <summary>
    /// The method to get a product by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Product GetProductById(Guid id)
    {
        return _context.Products.FirstOrDefault(p => p.Id == id);
    }

    /// <summary>
    /// The method to delete a product by id
    /// </summary>
    /// <param name="id"></param>
    public void DeleteProduct(Guid id)
    {
        Product productEntity = this.GetProductById(id);
        _context.Products.Remove(productEntity);
    }

    /// <summary>
    /// The method to get all products
    /// </summary>
    /// <returns></returns>
    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }
}
