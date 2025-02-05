using NETCoreTemplate.Mvc.Models;

namespace NETCoreTemplate.Mvc.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Sample Product 1", Description = "Description 1", Price = 19.99m, StockQuantity = 50 },
            new Product { Id = 2, Name = "Sample Product 2", Description = "Description 2", Price = 29.99m, StockQuantity = 30 }
        };
        private static int _nextId = 3;

        public IEnumerable<Product> GetAll()
        {
            return _products.ToList();
        }

        public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                var index = _products.IndexOf(existingProduct);
                _products[index] = product;
            }
        }

        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
} 