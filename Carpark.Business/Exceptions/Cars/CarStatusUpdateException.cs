namespace Carpark.Business.Exceptions.Cars;

public class CarStatusUpdateException : CarparkBusinessException
{
    public CarStatusUpdateException(string message) : base(message)
    {
    }
}