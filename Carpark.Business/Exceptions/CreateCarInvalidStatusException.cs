namespace Carpark.Business.Exceptions;

public class CreateCarInvalidStatusException : CarparkBusinessException
{
    public CreateCarInvalidStatusException() : base("Car could not be created; status must be OnOrder or Available")
    {
    }
}