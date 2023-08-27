using System.Text.Json.Serialization;

namespace Carpark.Api.Contracts.Cars;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UpdateStatusCarStatus
{
    OnOrder = 1,
    Available = 2,
    UnderRepairs = 4,
    Sold = 5
}