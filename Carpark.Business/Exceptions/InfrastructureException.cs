namespace Carpark.Business.Exceptions;

public class InfrastructureException : Exception
{
    public InfrastructureException(Exception innerException)
        : base("Something went wrong in the underlying infrastructure.", innerException)
    {
    }
}