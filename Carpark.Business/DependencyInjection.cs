using System.Runtime.CompilerServices;
using Carpark.Business.Cars;
using Carpark.Business.Integrations;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("Carpark.Business.UnitTests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Carpark.Business;

public static class ServiceCollection
{
    public static void AddServices(IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddScoped<IOpenDataRdwIntegration, OpenDataRdwIntegration>();
        services.AddScoped<ICarService, CarService>();
    }
}