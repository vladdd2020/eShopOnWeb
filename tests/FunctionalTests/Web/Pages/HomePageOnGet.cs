using Microsoft.eShopWeb.FunctionalTests.Web;
using Xunit;

namespace Microsoft.eShopWeb.FunctionalTests.WebRazorPages;

[Collection("Sequential")]
public class HomePageOnGet : IClassFixture<TestApplication>
{
    public HomePageOnGet(TestApplication factory)
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
        Console.WriteLine(stringResponse);
        Console.WriteLine($"Request URL: {Client.BaseAddress}/");
        Console.WriteLine($"HttpClient BaseAddress:{Client.BaseAddress}");

        // Assert
        Assert.Contains("Зарядна станція Bluetti AC200MAX", stringResponse);
    }
}
