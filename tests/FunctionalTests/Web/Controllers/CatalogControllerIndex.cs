using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.eShopWeb.FunctionalTests.Web.Controllers;

[Collection("Sequential")]
public class CatalogControllerIndex : IClassFixture<TestApplication>
{
    public CatalogControllerIndex(TestApplication factory)
    {
        Client = factory.CreateClient();
    }

    public HttpClient Client { get; }

    [Fact]
    public async Task ReturnsHomePageWithProductListing()
    {
        // Arrange & Act
        var response = await Client.GetAsync("/");
        response.EnsureSuccessStatusCode();
        var stringResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine(stringResponse);
        Console.WriteLine($"Request URL: {Client.BaseAddress}/");
        Console.WriteLine($"HttpClient BaseAddress:{Client.BaseAddress}");

        // Assert
        Assert.Contains("Зарядна станція Bluetti AC200MAX", stringResponse);
    }
}
