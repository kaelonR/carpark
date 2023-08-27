using Carpark.Business.Exceptions;
using Carpark.Business.Integrations;
using Carpark.Database.Repositories;
using Carpark.Domain;

namespace Carpark.Business.Cars;

internal class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    private readonly IOpenDataRdwIntegration _openDataRdwIntegration;
    
    public CarService(ICarRepository carRepository, IOpenDataRdwIntegration openDataRdwIntegration)
    {
        _carRepository = carRepository;
        _openDataRdwIntegration = openDataRdwIntegration;
    }

    public async Task<IEnumerable<Car>> GetCars(string? lentTo = null, CarStatus? status = null)
    {
        var filters = new Database.Repositories.Filters.GetCarsFilters();
        if (status != null)
            filters.Status = status;
        if (lentTo != null)
            filters.LentTo = lentTo;

        return await _carRepository.GetCars(filters);
    }
    
    public async Task<Car> CreateCar(string licensePlate, string colour, int constructionYear, CarStatus status, string? comments = null)
    {
        var formattedLicensePlate = licensePlate.Replace("-", string.Empty).ToUpper();
        var licensePlateExists = await _openDataRdwIntegration.LicensePlateExists(formattedLicensePlate);
        if (!licensePlateExists)
            throw new InvalidLicensePlateException(licensePlate);

        if (status != CarStatus.OnOrder && status != CarStatus.Available)
            throw new CreateCarInvalidStatusException();

        var car = new Car(formattedLicensePlate, colour, constructionYear, status)
        {
            Comments = comments ?? string.Empty
        };
        
        await _carRepository.SaveCar(car);
        return car;
    }
}