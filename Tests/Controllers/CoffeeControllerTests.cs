using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffee()
        {
            string expectedResult = "I like coffee!";
            var controller = new CoffeeController();
            var result = controller.GetMeCoffee();
            Assert.AreEqual(result, expectedResult);
        }
    }
}

