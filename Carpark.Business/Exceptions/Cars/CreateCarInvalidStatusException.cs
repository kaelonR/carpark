namespace Carpark.Business.Exceptions.Cars;

public class CreateCarInvalidStatusException : CarparkBusinessException
{
    public CreateCarInvalidStatusException() : base("Car could not be created; status must be OnOrder or Available")
    {
    }
}