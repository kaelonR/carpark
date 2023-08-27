using Carpark.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Carpark.Database;

public static class ServiceCollection
{
    public static void AddServices(IServiceCollection services)
    {
        services.AddScoped<CarparkContext>(_ => new CarparkContext());
        services.AddScoped<ICarRepository, CarRepository>();
    }
}