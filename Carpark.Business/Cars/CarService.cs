using Carpark.Database.Repositories;
using Carpark.Domain;

namespace Carpark.Business.Cars;

internal class CarService : ICarService
{
    private readonly ICarRepository _carRepository;

    public CarService(ICarRepository carRepository)
    {
        _carRepository = carRepository;
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
}