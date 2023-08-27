namespace Carpark.Domain;

public class Car
{
    public Car(string licensePlate, string colour, int constructionYear, CarStatus status)
    {
        LicensePlate = licensePlate;
        Colour = colour;
        ConstructionYear = constructionYear;
        Status = status;
    }

    public string LicensePlate { get; set; }
    public string Colour { get; set; }
    public int ConstructionYear { get; set; }
    public CarStatus Status { get; set; }
    
    public string? LentTo { get; set; }

    public string Comments { get; set; } = string.Empty;
}