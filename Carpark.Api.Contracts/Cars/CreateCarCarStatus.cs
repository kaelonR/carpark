using System.Text.Json.Serialization;

namespace Carpark.Api.Contracts.Cars;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CreateCarCarStatus
{
    OnOrder = 1,
    Available = 2
}