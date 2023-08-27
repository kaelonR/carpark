namespace Carpark.Business.Exceptions;

public class CarparkBusinessException : Exception
{
    public CarparkBusinessException(string message) : base(message)
    {
    }

    public CarparkBusinessException(string message, Exception innerException) : base(message, innerException)
    {
    }
}