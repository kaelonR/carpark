using Carpark.Api.Contracts.Cars;
using Carpark.Api.Factories;
using Carpark.Business.Cars;
using Carpark.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Carpark.Api.Controllers;

[Route("cars")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly ICarService _carService;
    
    public CarsController(ICarService carService)
    {
        _carService = carService;
    }

    /// <summary>
    /// Get a list of cars
    /// </summary>
    /// <param name="lentTo">optional parameter to searh for cars lent out to a specific person</param>
    /// <param name="status">optional parameter to searh for cars with a specific status</param>
    /// <response code="200">A list of cars</response>
    /// <response code="422">Request could not be processed; a status filter with an invalid value was supplied.</response>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<CarResponse>), StatusCodes.Status200OK, "application/json")]
    [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> GetCars([FromQuery(Name = "lent-to")] string? lentTo = null, [FromQuery] CarStatus? status = null)
    {
        var cars = await _carService.GetCars(lentTo, status);
        var response = cars.Select(CarResponseFactory.Construct);
        
        return new JsonResult(response);
    }
}