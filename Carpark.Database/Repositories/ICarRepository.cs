using Carpark.Database.Exceptions;
using Carpark.Database.Repositories.Filters;

namespace Carpark.Database.Repositories;

public interface ICarRepository
{
    Task<Domain.Car?> GetCar(string licensePlate);
    
    Task<Domain.Car[]> GetCars(GetCarsFilters? filters = null);

    /// <summary>
    /// Save a car to the database
    /// </summary>
    /// <param name="car">The car to save</param>
    /// <exception cref="DatabaseUpdateException"> Something went wrong while attempting to update the database.</exception>
    Task SaveCar(Domain.Car car);
}