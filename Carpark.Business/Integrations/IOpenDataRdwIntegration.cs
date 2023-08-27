namespace Carpark.Business.Integrations;

internal interface IOpenDataRdwIntegration
{
    Task<bool> LicensePlateExists(string licensePlate);
}