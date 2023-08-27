using Carpark.Domain;

namespace Carpark.Business.Cars;

public interface ICarService
{
    Task<IEnumerable<Car>> GetCars(string? lentTo = null, CarStatus? status = null);
    
    /// <summary>
    /// Create a new car.
    /// </summary>
    /// <param name="licensePlate">License plate of the car. Will be verified against https://opendata.rdw.nl/resource/m9d7-ebf2.json.</param>
    /// <param name="colour">Main colour of the car</param>
    /// <param name="constructionYear">Year in which the car was built.</param>
    /// <param name="status">Status of the car. Must be <see cref="CarStatus.OnOrder"/> or <see cref="CarStatus.Available"/>.</param>
    /// <param name="comments">Comments relating to the car, if any.</param>
    /// <exception cref="Exceptions.Cars.InvalidLicensePlateException">Thrown if the license plate could not be verified</exception>
    /// <exception cref="Exceptions.Cars.CreateCarInvalidStatusException">Thrown if the status is not OnOrder or Available</exception>
    /// <exception cref="Exceptions.InfrastructureException">Thrown if something went wrong in the underlying infrastructure</exception>
    Task<Car> CreateCar(string licensePlate, string colour, int constructionYear, CarStatus status, string comments = null);

    /// <summary>
    /// Update a car's status.
    /// </summary>
    /// <param name="licensePlate">License plate of the car to update</param>
    /// <param name="status">Status to set the car to</param>
    /// <exception cref="Exceptions.Cars.CarStatusUpdateException">Thrown if the status update cannot be applied for any reason.</exception>
    /// <exception cref="Exceptions.Cars.CarNotFoundException">Thrown if the car could not be found</exception>
    /// <exception cref="Exceptions.InfrastructureException">Thrown if something went wrong in the underlying infrastructure</exception>
    Task UpdateStatus(string licensePlate, CarStatus status);

    /// <summary>
    /// Lend a car out to a person.
    /// </summary>
    /// <param name="licensePlate">License plate of the car to lend</param>
    /// <param name="personName">Person to lend the car to</param>
    /// <exception cref="Exceptions.Cars.CarStatusUpdateException">Thrown if the car is not available.</exception>
    /// <exception cref="Exceptions.Cars.CarNotFoundException">Thrown if the car could not be found</exception>
    /// <exception cref="Exceptions.InfrastructureException">Thrown if something went wrong in the underlying infrastructure</exception>
    Task LendCarTo(string licensePlate, string personName);
}