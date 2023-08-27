namespace Carpark.Business.Exceptions.Cars;

public class CarNotFoundException : CarparkBusinessException
{
    public CarNotFoundException() : base("No car with the given license plate could be found in the database")
    {
    }
}