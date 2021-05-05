using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecretSanta.Web.Api;
using SecretSanta.Web.Tests.Api;
using SecretSanta.Web.ViewModels;

namespace SecretSanta.Web.Tests
{
    [TestClass]
    public class UsersControllerTest
    {
        private WebApplicationFactory Factory {get;} = new();

        [TestMethod]
        public async Task Index_InvokesGetAllAsync()

        {
            // Arrange
            User user1 = new() 
            {
                Id = 1,
                FirstName = "Yousef",
                LastName = "Baghlaf"
            };

            User user2 = new() 
            {
                Id = 2,
                FirstName = "Mohammed",
                LastName = "Ali"
            };

            TestableUsersClient usersClient = Factory.Client;
            usersClient.GetAllUsersReturnValue = new List<User>(){
                user1, user2
            };

            HttpClient client = Factory.CreateClient();

            // Act
            HttpResponseMessage response = await client.GetAsync("/Users/");

            string foo = await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(1, usersClient.GetAllAsyncInvocationCount);
        }

        [TestMethod]
        public async Task Create_WithValidModel_InvokesPostAsync()
        {
            //Arrange
            HttpClient client = Factory.CreateClient();
            TestableUsersClient usersClient = Factory.Client;

            Dictionary<string, string?> values = new()
            {
                { nameof(UserViewModel.FirstName), "Yousef" }
            };
            FormUrlEncodedContent content = new(values!);

            //Act
            HttpResponseMessage response = await client.PostAsync("/Events/Create", content);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(1, usersClient.PostAsyncInvocationCount);
            Assert.AreEqual(1, usersClient.PostAsyncInvokedParameters.Count);
            Assert.AreEqual("Yousef", usersClient.PostAsyncInvokedParameters[0].FirstName);
        }
    }
}
