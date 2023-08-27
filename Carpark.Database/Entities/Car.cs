using System.ComponentModel.DataAnnotations;
using Carpark.Domain;

namespace Carpark.Database.Entities;

public class Car
{
    [Key]
    public string LicensePlate { get; set; } = null!;
    public string Colour { get; set; } = null!;
    public int ConstructionYear { get; set; }
    public CarStatus Status { get; set; }
    public string LentTo { get; set; } = string.Empty;
    public string Comments { get; set; } = string.Empty;
}