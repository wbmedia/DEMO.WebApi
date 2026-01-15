using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMO.WebApi.Controllers
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Services.IProductService _productService;
        public ProductController(Services.IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{id:guid}")]
        public IActionResult GetProductById(Guid id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Models.ProductModel productModel)
        {
            _productService.CreateProduct(productModel);
            return CreatedAtAction(nameof(GetProductById), new { id = productModel.Name }, productModel);
        }
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteProduct(Guid id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}
