using Microsoft.AspNetCore.Mvc;
using MongoAPI.Models;
using MongoAPI.Services;

namespace MongoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            try
            {
                var products = await _productService.GetAllAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all products");
                return StatusCode(500, "An error occurred while retrieving products. Please check if MongoDB is running.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(string id)
        {
            try
            {
                var product = await _productService.GetByIdAsync(id);
                
                if (product == null)
                {
                    return NotFound($"Product with ID {id} not found.");
                }

                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving product with ID: {ProductId}", id);
                return StatusCode(500, "An error occurred while retrieving the product. Please check if MongoDB is running.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            try
            {
                var createdProduct = await _productService.CreateAsync(product);
                return CreatedAtAction(nameof(GetProduct), new { id = createdProduct.Id }, createdProduct);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating product: {ProductName}", product.Name);
                return StatusCode(500, "An error occurred while creating the product. Please check if MongoDB is running.");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(string id, Product product)
        {
            try
            {
                var existingProduct = await _productService.GetByIdAsync(id);
                
                if (existingProduct == null)
                {
                    return NotFound($"Product with ID {id} not found.");
                }

                product.Id = existingProduct.Id;
                await _productService.UpdateAsync(id, product);
                
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating product with ID: {ProductId}", id);
                return StatusCode(500, "An error occurred while updating the product. Please check if MongoDB is running.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            try
            {
                var product = await _productService.GetByIdAsync(id);
                
                if (product == null)
                {
                    return NotFound($"Product with ID {id} not found.");
                }

                await _productService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting product with ID: {ProductId}", id);
                return StatusCode(500, "An error occurred while deleting the product. Please check if MongoDB is running.");
            }
        }

        [HttpGet("category/{category}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string category)
        {
            try
            {
                var products = await _productService.GetByCategoryAsync(category);
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving products by category: {Category}", category);
                return StatusCode(500, "An error occurred while retrieving products by category. Please check if MongoDB is running.");
            }
        }

        [HttpGet("instock")]
        public async Task<ActionResult<List<Product>>> GetInStockProducts()
        {
            try
            {
                var products = await _productService.GetInStockAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving in-stock products");
                return StatusCode(500, "An error occurred while retrieving in-stock products. Please check if MongoDB is running.");
            }
        }
    }
}
