using MongoDB.Driver;
using MongoAPI.Models;

namespace MongoAPI.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _products;
        private readonly ILogger<ProductService>? _logger;

        public ProductService(MongoDbSettings settings, ILogger<ProductService>? logger = null)
        {
            _logger = logger;
            
            try
            {
                var client = new MongoClient(settings.ConnectionString);
                var database = client.GetDatabase(settings.DatabaseName);
                _products = database.GetCollection<Product>(settings.ProductCollectionName);
                
                _logger?.LogInformation("Successfully connected to MongoDB at {ConnectionString}", settings.ConnectionString);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Failed to connect to MongoDB at {ConnectionString}", settings.ConnectionString);
                throw;
            }
        }

        public async Task<List<Product>> GetAllAsync()
        {
            try
            {
                return await _products.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting all products");
                throw;
            }
        }

        public async Task<Product?> GetByIdAsync(string id)
        {
            try
            {
                return await _products.Find(x => x.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting product by ID: {ProductId}", id);
                throw;
            }
        }

        public async Task<Product> CreateAsync(Product product)
        {
            try
            {
                await _products.InsertOneAsync(product);
                _logger?.LogInformation("Created new product: {ProductName}", product.Name);
                return product;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error creating product: {ProductName}", product.Name);
                throw;
            }
        }

        public async Task UpdateAsync(string id, Product product)
        {
            try
            {
                product.UpdatedAt = DateTime.UtcNow;
                await _products.ReplaceOneAsync(x => x.Id == id, product);
                _logger?.LogInformation("Updated product: {ProductId}", id);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error updating product: {ProductId}", id);
                throw;
            }
        }

        public async Task DeleteAsync(string id)
        {
            try
            {
                await _products.DeleteOneAsync(x => x.Id == id);
                _logger?.LogInformation("Deleted product: {ProductId}", id);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error deleting product: {ProductId}", id);
                throw;
            }
        }

        public async Task<List<Product>> GetByCategoryAsync(string category)
        {
            try
            {
                return await _products.Find(x => x.Category.ToLower() == category.ToLower()).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting products by category: {Category}", category);
                throw;
            }
        }

        public async Task<List<Product>> GetInStockAsync()
        {
            try
            {
                return await _products.Find(x => x.InStock == true).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting in-stock products");
                throw;
            }
        }
    }
}
