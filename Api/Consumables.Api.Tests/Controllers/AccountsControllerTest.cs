using Consumables.Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Consumables.Api.Tests.Controllers
{
    [TestClass]
    public class AccountsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            AccountsController controller = new AccountsController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            AccountsController controller = new AccountsController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            AccountsController controller = new AccountsController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            AccountsController controller = new AccountsController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            AccountsController controller = new AccountsController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
