using System.ComponentModel.DataAnnotations;

namespace Carpark.Api.Contracts.Cars;

public class LendCarPayload
{
    /// <summary>
    /// The person that the car is being lended to.
    /// </summary>
    [Required]
    public string PersonName { get; set; } = null!;
}