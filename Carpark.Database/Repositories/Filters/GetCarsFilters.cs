using Carpark.Domain;

namespace Carpark.Database.Repositories.Filters;

public class GetCarsFilters
{
    public string? LentTo { get; set; }
    public CarStatus? Status { get; set; }
}