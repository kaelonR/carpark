namespace Carpark.Database.Mappers;

internal static class CarMapper
{
    public static Domain.Car ToDomainModel(Entities.Car dbCar)
        => new(dbCar.LicensePlate, dbCar.Colour, dbCar.ConstructionYear, dbCar.Status)
        {
            LentTo = dbCar.LentTo,
            Comments = dbCar.Comments
        };

    public static Entities.Car ToDatabaseModel(Domain.Car car)
        => new()
        {
            LicensePlate = car.LicensePlate,
            Colour = car.Colour,
            ConstructionYear = car.ConstructionYear,
            Status = car.Status,
            LentTo = car.LentTo,
            Comments = car.Comments
        };
}