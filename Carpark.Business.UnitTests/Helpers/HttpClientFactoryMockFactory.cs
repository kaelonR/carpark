using Moq;
using Moq.Protected;

namespace Carpark.Domain.UnitTests.Helpers;

public static class HttpClientFactoryMockFactory
{
    /// <summary>
    /// Create a mocked IHttpClientFactory, which will construct a HttpClient that always returns a fixed response.
    /// </summary>
    /// <param name="responseString"></param>
    /// <returns></returns>
    public static (IHttpClientFactory factory, Func<HttpRequestMessage?> getCapturedRequestMessage) Construct(string responseString)
    {
        var mockFactory = new Mock<IHttpClientFactory>();
        var messageHandlerMock = new Mock<HttpMessageHandler>();

        var httpResponseMessage = new HttpResponseMessage
        {
            Content = new StringContent(responseString)
        };

        HttpRequestMessage? sentRequestMessage = null;
        
        messageHandlerMock
            .Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .Callback<HttpRequestMessage, CancellationToken>((x, _) => sentRequestMessage = x)
            .ReturnsAsync(httpResponseMessage);

        var httpClient = new HttpClient(messageHandlerMock.Object);
        mockFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(httpClient);
        
        return (mockFactory.Object, () => sentRequestMessage);
    }
}