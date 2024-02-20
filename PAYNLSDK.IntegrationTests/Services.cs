using PayNlSdk.IntegrationTests.Helpers;

#pragma warning disable CS8604 // Possible null reference argument.

namespace PayNlSdk.IntegrationTests;

public class Services
{
    [Fact]
    public async Task CanGetServices()
    {
        var client = TestHelper.CreateClient();

        var services = await client.GetAllServices();

        Assert.NotNull(services);
        Assert.NotEmpty(services.Services);
        Assert.True(services.Total > 0);
        Assert.Equal(services.Total, services.Services.Count);
    }
}