using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;
using FluentAssertions;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffeeLover()
        {
            string expectedResult = "I love coffee!";
            var controller = new CoffeeController();
            var result = controller.GetMeMyCoffeeLover();
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void TestGetCoffee()
        {
            var expectedCoffee = new Coffee();
            expectedCoffee.Id = 3;
            expectedCoffee.Name = "Chai Tea Latte";
            var controller = new CoffeeController();
            var myDeliciousCoffee = controller.Get("Chai Tea Latte");
            Assert.AreEqual(expectedCoffee.Name, myDeliciousCoffee.Name);
            Assert.AreEqual(expectedCoffee.Id, myDeliciousCoffee.Id);
        }
    }
}

