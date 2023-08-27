namespace Carpark.Domain;

public class Car
{
    public Car(string licensePlate, string colour, int constructionYear, CarStatus carStatus)
    {
        LicensePlate = licensePlate;
        Colour = colour;
        ConstructionYear = constructionYear;
        CarStatus = carStatus;
    }

    public string LicensePlate { get; set; }
    public string Colour { get; set; }
    public int ConstructionYear { get; set; }
    public CarStatus CarStatus { get; set; }
    
    public string LentTo { get; set; } = string.Empty;

    public string Comments { get; set; } = string.Empty;
}