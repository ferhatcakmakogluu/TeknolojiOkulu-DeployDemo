using DeployApp.API.Models;

namespace DeployApp.API.Services
{
    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            // Uygulama başlarken bu liste oluşturulur
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 15000 },
            new Product { Id = 2, Name = "Mouse", Price = 500 },
            new Product { Id = 3, Name = "Keyboard", Price = 800 },
            new Product { Id = 4, Name = "TV", Price = 25000 },
            new Product { Id = 5, Name = "Ps5", Price = 15000 },
            new Product { Id = 6, Name = "AirPods", Price = 4500 },
            new Product { Id = 7, Name = "IPad", Price = 28500 },
            new Product { Id = 8, Name = "IMac", Price = 65000 }
        };
        }

        public IEnumerable<Product> GetAll() => _products;
    }
}
