using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    [ApiController]
    public class ProductController : Controller
    {
        Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Fiat 500 Rockstar", Category = "Kleinwagen", Price = 99, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSh5247013nCq_Ihvz7xg0vAHssaxTBUsHvqw&usqp=CAU"},
            new Product {Id = 2, Name = "Hyundai Tucson", Category = "SUV", Price = 249.99M, Image="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQt6_FECQxl-Ix_0U5__6JFr-rOvN5l0psnvA&usqp=CAU"},
            new Product {Id = 3, Name = "Ford Kuga", Category = "SUV", Price = 199.99M, Image="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRssL24B23UJ1np6AyZmtlE7ui-qFFzjaAr9A&usqp=CAU"}
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }
    }
}
