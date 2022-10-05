using System;
using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {

        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            return new Coffee
            {
                Id = (name != null ? 3: -1),
                Name = name ?? "latte"
            };

        }
        [HttpGet("lover")]
        public string GetMeMyCoffeeLover()
        {
            return "I love coffee!";
        }
    }
}

