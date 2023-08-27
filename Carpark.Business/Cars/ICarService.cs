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
    /// <returns></returns>
    /// <exception cref="InvalidLicensePlateException">Thrown if the license plate could not be verified</exception>
    /// <exception cref="CreateCarInvalidStatusException">Thrown if the status is not OnOrder or Available</exception>
    /// <exception cref="InfrastructureException">Thrown if something went wrong in the underlying infrastructure</exception>
    Task<Car> CreateCar(string licensePlate, string colour, int constructionYear, CarStatus status, string comments = null);
}