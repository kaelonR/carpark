namespace Carpark.Business.Exceptions.Cars;

public class InvalidLicensePlateException : CarparkBusinessException
{
    public InvalidLicensePlateException(string licensePlate)
        : base($"Cannot create car because the given license plate could not be verified: {licensePlate}")
    {
    }
}