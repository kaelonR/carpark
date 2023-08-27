using System.ComponentModel.DataAnnotations;

namespace Carpark.Api.Contracts.Cars;

public class CreateCarPayload
{
    /// <summary>
    /// License plate of the car.
    /// </summary>
    [Required]
    public string LicensePlate { get; set; } = null!;
    
    /// <summary>
    /// Main colour of the car.
    /// </summary>
    [Required]
    public string Colour { get; set; } = null!;
    
    /// <summary>
    /// The year in which the car was constructed.
    /// </summary>
    [Required]
    public int ConstructionYear { get; set; }

    /// <summary>
    /// Status of the car. OnOrder or Available.
    /// For any other status, change the status of the car after creation, or use the /cars/{id}/lent-to endpoint to set a lender.
    /// </summary>
    [Required]
    public CreateCarCarStatus Status { get; set; }

    /// <summary>
    /// Any comments related to the car. Optional.
    /// </summary>
    public string Comments { get; set; } = string.Empty;
}