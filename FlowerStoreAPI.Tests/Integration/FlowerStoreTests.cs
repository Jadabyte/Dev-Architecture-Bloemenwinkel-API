using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Snapshooter;
using Snapshooter.Xunit;
using FluentAssertions;
using FlowerStoreAPI.Models;
using FlowerStoreAPI.Tests.Integration.Utils;
using Newtonsoft.Json;

namespace FlowerStoreAPI.Tests.Integration
{
    public class FlowerStoreTests : IClassFixture<WebApplicationFactory<Startup>>
    {

        private readonly WebApplicationFactory<Startup> _factory;

        public FlowerStoreTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetProductsEndpointReturnsSomeDataWhenDbIsNotEmpty()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/products");

            // Assert
            response.EnsureSuccessStatusCode(); // Status code 200-299
            Snapshot.Match(await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task GetProductByIdReturnGarageIfExists()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/products/1");

            // Assert
            response.EnsureSuccessStatusCode(); // Status code 200-299
            Snapshot.Match(await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task DeleteProductByIdReturnsDeletesIfExists()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var beforeDeleteResponse = await client.GetAsync("/api/products/1");
            // Assert
            beforeDeleteResponse.EnsureSuccessStatusCode();

            // Act
            var deleteResponse = await client.DeleteAsync("/api/products/1");
            // Assert
            deleteResponse.EnsureSuccessStatusCode();

            // Act
            var afterDeleteResponse = await client.GetAsync("/api/products/1");
            // Assert
            afterDeleteResponse.StatusCode.Should().Be(404);
        }

        [Fact]
        public async Task InsertProductReturnsCorrectData()
        {

            var client = _factory.CreateClient();

            var request = new
            {
                Body = new Product
                {
                    Name = "ASpecialFlower",
                    Category = "NotSoSpecialCategory",
                    Price = 9.99M
                }
            };

            var createResponse = await client.PostAsync("/api/products", ContentHelper.GetStringContent(request.Body));
            createResponse.EnsureSuccessStatusCode();

            var body = JsonConvert.DeserializeObject<Product>(await createResponse.Content.ReadAsStringAsync());

            body.Should().NotBeNull();
            body.Name.Should().Be("ASpecialFlower");
            body.Category.Should().Be("NotSoSpecialCategory");
            body.Price.Should().Be(9.99M);

            var getResponse = await client.GetAsync($"/api/products/{body.Id}");
            getResponse.EnsureSuccessStatusCode();

        }

        [Fact]
        public async Task InsertProductThrowsErrorOnEmptyName()
        {
            var client = _factory.CreateClient();

            var request = new
            {
                Body = new Product
                {
                    Name = "",
                    Category = "AnotherSpecialCategory",
                    Price = 4.44M
                }
            };

            var createResponse = await client.PostAsync("/api/products", ContentHelper.GetStringContent(request.Body));
            createResponse.StatusCode.Should().Be(400);
        }

        [Fact]
        public async Task InsertProductThrowsErrorOnNameWithTooMuchCharacters()
        {
            var client = _factory.CreateClient();

            var request = new
            {
                Body = new Product
                {
                    Name = new string('a', 200),
                    Category = "WowFlowers",
                    Price = 1.23M
                }
            };

            var createResponse = await client.PostAsync("/api/products", ContentHelper.GetStringContent(request.Body));
            createResponse.StatusCode.Should().Be(400);
        }

    }
}
