using Carpark.Business.Exceptions;
using Carpark.Business.Exceptions.Cars;
using Carpark.Business.Exceptions.Pagination;
using Carpark.Business.Integrations;
using Carpark.Database.Exceptions;
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

    public async Task<(IEnumerable<Car> cars, int totalCarCount)> GetCars(int page = 1, int itemsPerPage = 25, string? lentTo = null, CarStatus? status = null)
    {
        if (page <= 0)
            throw new IndexOutOfRangeException("page must be 1 or higher.");
        if (itemsPerPage < 1 || itemsPerPage > 50)
            throw new ItemsPerPageOutOfBoundsException("itemsPerPage must be between 1 and 50.");
        
        var filters = new Database.Repositories.Filters.GetCarsFilters();
        if (status != null)
            filters.Status = status;
        if (lentTo != null)
            filters.LentTo = lentTo;

        return await _carRepository.GetCars(page, itemsPerPage, filters);
    }

    public async Task<Car> GetCar(string licensePlate)
    {
        var formattedLicensePlate = FormatLicensePlate(licensePlate);
        var car = await _carRepository.GetCar(formattedLicensePlate);
        if (car == null)
            throw new CarNotFoundException();

        return car;
    }

    public async Task<Car> CreateCar(string licensePlate, string colour, int constructionYear, CarStatus status, string? comments = null)
    {
        var formattedLicensePlate = FormatLicensePlate(licensePlate);
        var licensePlateExists = await _openDataRdwIntegration.LicensePlateExists(formattedLicensePlate);
        if (!licensePlateExists)
            throw new InvalidLicensePlateException(licensePlate);

        if (status != CarStatus.OnOrder && status != CarStatus.Available)
            throw new CreateCarInvalidStatusException();

        var car = new Car(formattedLicensePlate, colour, constructionYear, status)
        {
            Comments = comments ?? string.Empty
        };

        try
        {
            await _carRepository.SaveCar(car);
            return car;
        }
        catch (DatabaseUpdateException e)
        {
            throw new InfrastructureException(e);
        }
    }

    public async Task UpdateStatus(string licensePlate, CarStatus status)
    {
        if (status == CarStatus.LentOut)
            throw new CarStatusUpdateException("Car status cannot be set to LentOut status; " +
                "use the appropriate endpoint to ensure the person the car is lent out to is set correctly.");
        if (status == CarStatus.OnOrder)
            throw new CarStatusUpdateException("Car status cannot be set to OnOrder.");
        
        var formattedLicensePlate = FormatLicensePlate(licensePlate);
        var car = await _carRepository.GetCar(formattedLicensePlate);
        
        if (car == null)
            throw new CarNotFoundException();
        if (car.Status == CarStatus.Sold)
            throw new CarStatusUpdateException("Car status cannot be updated; car is already sold.");

        car.Status = status;
        car.LentTo = null;

        try
        {
            await _carRepository.SaveCar(car);
        }
        catch (DatabaseUpdateException e)
        {
            throw new InfrastructureException(e);
        }
    }

    public async Task LendCarTo(string licensePlate, string personName)
    {
        var formattedLicensePlate = FormatLicensePlate(licensePlate);
        var car = await _carRepository.GetCar(formattedLicensePlate);
        if (car == null)
            throw new CarNotFoundException();
        if (car.Status != CarStatus.Available)
            throw new CarStatusUpdateException("Car cannot be lent out; car is not available.");

        car.Status = CarStatus.LentOut;
        car.LentTo = personName;

        try
        {
            await _carRepository.SaveCar(car);
        }
        catch (DatabaseUpdateException e)
        {
            throw new InfrastructureException(e);
        }
    }

    private string FormatLicensePlate(string licensePlate)
        => licensePlate.Replace("-", string.Empty).ToUpper();
}