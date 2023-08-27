namespace Carpark.Business.Exceptions;

public class InvalidLicensePlateException : Exception
{
    public InvalidLicensePlateException(string licensePlate)
        : base($"Cannot create car because the given license plate could not be verified: {licensePlate}")
    {
    }
}