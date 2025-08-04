using Microsoft.AspNetCore.Mvc;
using MongoAPI.Services;

namespace MongoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly ILogger<HealthController> _logger;

        public HealthController(ProductService productService, ILogger<HealthController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> CheckHealth()
        {
            try
            {
                // Try to connect to MongoDB by getting count of products
                var products = await _productService.GetAllAsync();
                return Ok(new { 
                    status = "healthy", 
                    message = "API and MongoDB are running correctly",
                    timestamp = DateTime.UtcNow,
                    productCount = products.Count
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Health check failed");
                return StatusCode(500, new { 
                    status = "unhealthy", 
                    message = "MongoDB connection failed. Please check if MongoDB is running on port 8081",
                    error = ex.Message,
                    timestamp = DateTime.UtcNow
                });
            }
        }

        [HttpGet("ping")]
        public ActionResult Ping()
        {
            return Ok(new { 
                status = "alive", 
                message = "API is running",
                timestamp = DateTime.UtcNow
            });
        }
    }
}
