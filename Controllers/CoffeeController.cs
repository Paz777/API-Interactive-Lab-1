using System;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("Coffee")]
    public class CoffeeController : ControllerBase
    {

        [HttpGet]
        public string GetMeCoffee()
        {
            return "I like coffee!";
        }
    }
}

