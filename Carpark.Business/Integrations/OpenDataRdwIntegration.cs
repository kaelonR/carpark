using System.Net;
using System.Text.Json;

namespace Carpark.Business.Integrations;

internal class OpenDataRdwIntegration : IOpenDataRdwIntegration
{
    private readonly IHttpClientFactory _httpClientFactory;

    public OpenDataRdwIntegration(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<bool> LicensePlateExists(string licensePlate)
    {
        var formattedLicensePlate = licensePlate.Replace("-", string.Empty).ToUpper();
        
        var httpClient = _httpClientFactory.CreateClient();
        var response = await httpClient.GetAsync($"https://opendata.rdw.nl/resource/m9d7-ebf2.json?kenteken={formattedLicensePlate}");
        if (response.StatusCode != HttpStatusCode.OK)
            return false;

        var jsonBody = await response.Content.ReadAsStringAsync();
        var jsonDocument = JsonDocument.Parse(jsonBody);

        var carExists = jsonDocument.RootElement.ValueKind == JsonValueKind.Array && jsonDocument.RootElement.GetArrayLength() == 1;
        return carExists;
    }
}