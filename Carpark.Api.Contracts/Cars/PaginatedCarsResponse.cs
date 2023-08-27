namespace Carpark.Api.Contracts.Cars;

public class PaginatedCarsResponse
{
    public int Page { get; set; }
    public int ItemsPerPage { get; set; }
    public int TotalItems { get; set; }
    public int AmountOfPages { get; set; }
    public IEnumerable<CarResponse> Cars { get; set; }
}