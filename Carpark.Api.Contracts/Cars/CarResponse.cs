using System.Text.Json.Serialization;
using Carpark.Domain;

namespace Carpark.Api.Contracts.Cars;

public class CarResponse
{
    public CarResponse(string licensePlate, string colour, int constructionYear, CarStatus status)
    {
        LicensePlate = licensePlate;
        Colour = colour;
        ConstructionYear = constructionYear;
        Status = status;
    }

    /// <summary>
    /// The car's license plate. This serves as identifier for the car.
    /// </summary>
    public string LicensePlate { get; set; }
    
    /// <summary>
    /// The main colour of the car
    /// </summary>
    public string Colour { get; set; }
    
    /// <summary>
    /// The year in which the car was constructed
    /// </summary>
    public int ConstructionYear { get; set; }
    
    /// <summary>
    /// The current status of the car
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public CarStatus Status { get; set; }
    
    /// <summary>
    /// Who the car is lent out to, if lent out. Otherwise null.
    /// </summary>
    public string? LentTo { get; set; }

    /// <summary>
    /// Any comments related to the car, if any.
    /// </summary>
    public string Comments { get; set; } = string.Empty;
}