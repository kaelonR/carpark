using Carpark.Business.Cars;
using Microsoft.Extensions.DependencyInjection;

namespace Carpark.Business;

public static class ServiceCollection
{
    public static void AddServices(IServiceCollection services)
    {
        services.AddScoped<ICarService, CarService>();
    }
}