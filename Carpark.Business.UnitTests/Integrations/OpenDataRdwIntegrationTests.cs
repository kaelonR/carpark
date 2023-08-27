using Carpark.Business.Integrations;
using Carpark.Domain.UnitTests.Helpers;
using Moq;
using Moq.Protected;
using NUnit.Framework;

namespace Carpark.Domain.UnitTests.Integrations;

public class OpenDataRdwIntegrationTests
{
    [TestCase]
    public async Task LicensePlateExists_SendsRequestContainingLicensePlate()
    {
        //arrange
        var staticResponse = "[{}]"; //array with 1 item, which means the license plate exists
        var (httpClientFactory, getCapturedRequestMessage) = HttpClientFactoryMockFactory.Construct(staticResponse);
        
        
        var integration = new OpenDataRdwIntegration(httpClientFactory);

        //act
        await integration.LicensePlateExists("real license plate");

        //assert
        var requestSentFromIntegration = getCapturedRequestMessage();
        Assert.IsNotNull(requestSentFromIntegration);
        Assert.IsTrue(requestSentFromIntegration!.RequestUri?.ToString().Contains("real license plate", StringComparison.OrdinalIgnoreCase));
    }
    
    [TestCase]
    public async Task LicensePlateExists_ReturnsTrue_ForRealLicensePlate()
    {
        //arrange
        var staticResponse = "[{}]"; //array with 1 item, which means the license plate exists
        var (httpClientFactory, _) = HttpClientFactoryMockFactory.Construct(staticResponse);
        var integration = new OpenDataRdwIntegration(httpClientFactory);

        //act
        var plateExists = await integration.LicensePlateExists("real license plate");

        //assert
        Assert.IsTrue(plateExists);
    }

    [TestCase]
    public async Task LicensePlateExists_ReturnsFalse_ForNonExistingLicensePlate()
    {
        //arrange
        var staticResponse = "[]"; //empty array, which means the license plate was not found
        var (httpClientFactory, _) = HttpClientFactoryMockFactory.Construct(staticResponse);
        var integration = new OpenDataRdwIntegration(httpClientFactory);

        //act
        var plateExists = await integration.LicensePlateExists("fake plate");

        //assert
        Assert.IsFalse(plateExists);
    }
    
    [TestCase]
    public async Task LicensePlateExists_ReturnsFalse_WhenMultipleResultsFounds()
    {
        //arrange
        var staticResponse = "[{},{}]"; //multiple results
        var (httpClientFactory, _) = HttpClientFactoryMockFactory.Construct(staticResponse);
        var integration = new OpenDataRdwIntegration(httpClientFactory);

        //act
        var plateExists = await integration.LicensePlateExists("fake plate");

        //assert
        Assert.IsFalse(plateExists);
    }
}