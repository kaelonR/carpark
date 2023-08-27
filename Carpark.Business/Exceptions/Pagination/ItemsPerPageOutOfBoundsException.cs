namespace Carpark.Business.Exceptions.Pagination;

public class ItemsPerPageOutOfBoundsException : CarparkBusinessException
{
    public ItemsPerPageOutOfBoundsException(string message) : base(message)
    {
    }
}