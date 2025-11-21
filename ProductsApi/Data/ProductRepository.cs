using ProductsApi.Models;

namespace ProductsApi.Data
{
    public static class ProductRepository
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 85000, Quantity = 5 },
            new Product { Id = 2, Name = "Mouse", Description = "Wireless Mouse", Price = 850, Quantity = 20 },
            new Product { Id = 3, Name = "Keyboard", Description = "Mechanical Keyboard", Price = 2500, Quantity = 10 }
        };
    }
}
