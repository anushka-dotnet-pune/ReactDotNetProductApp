using Microsoft.AspNetCore.Mvc;
using ProductsApi.Data;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(ProductRepository.Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            product.Id = ProductRepository.Products.Max(p => p.Id) + 1;
            ProductRepository.Products.Add(product);

            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updated)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            product.Name = updated.Name;
            product.Description = updated.Description;
            product.Price = updated.Price;
            product.Quantity = updated.Quantity;

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            ProductRepository.Products.Remove(product);
            return Ok("Deleted");
        }
    }
}
