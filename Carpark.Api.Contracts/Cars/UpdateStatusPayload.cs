using System.ComponentModel.DataAnnotations;

namespace Carpark.Api.Contracts.Cars;

public class UpdateStatusPayload
{
    /// <summary>
    /// Car status to set.
    /// In order to set the status to "LentOut", use the /cars/{id}/lent-to endpoint instead.
    /// </summary>
    [Required]
    public UpdateStatusCarStatus Status { get; set; }
}