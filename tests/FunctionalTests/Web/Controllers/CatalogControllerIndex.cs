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
        Client.BaseAddress = new Uri("https://app-web-mhksjsbvelan6.azurewebsites.net/");
    }

    public HttpClient Client { get; }

    [Fact]
    public async Task ReturnsHomePageWithProductListing()
    {
        // Arrange & Act
        var response = await Client.GetAsync("/");
        response.EnsureSuccessStatusCode();
        var stringResponse = await response.Content.ReadAsStringAsync();


        // Assert
        Assert.Contains("Зарядна станція Bluetti AC200MAX", stringResponse);
    }
}
