using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SecretSanta.Api.Controllers;
using System.Collections.Generic;
using SecretSanta.Business;
using SecretSanta.Data;

namespace SecretSanta.Api.Tests.Controllers{
    [TestClass]
    public class UsersControllerTests{
        [TestMethod]
        public void Get_WithData_ReturnsGifts() {
            // Arrange
            UsersController controller = new(new UserRepository());

            // Act
            IEnumerable<User> users = controller.Get();

            //Assert
            Assert.IsTrue(users.Any());
        }
    }

}