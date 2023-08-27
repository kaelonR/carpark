using Carpark.Api.Contracts.Cars;

namespace Carpark.Api.Factories;

public static class CarResponseFactory
{
    public static CarResponse Construct(Domain.Car car)
        => new(car.LicensePlate, car.Colour, car.ConstructionYear, car.Status)
        {
            LentTo = string.IsNullOrEmpty(car.LentTo) ? null : car.LentTo,
            Comments = car.Comments
        };
}