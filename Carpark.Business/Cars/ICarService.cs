using Carpark.Domain;

namespace Carpark.Business.Cars;

public interface ICarService
{
    Task<IEnumerable<Car>> GetCars(string? lentTo = null, CarStatus? status = null);
}