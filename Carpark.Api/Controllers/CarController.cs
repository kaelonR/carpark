using Carpark.Api.Contracts.Cars;
using Carpark.Api.Factories;
using Carpark.Business.Cars;
using Carpark.Business.Exceptions;
using Carpark.Business.Exceptions.Cars;
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
    /// <param name="lentTo">optional parameter to search for cars lent out to a specific person</param>
    /// <param name="status">optional parameter to search for cars with a specific status</param>
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

    /// <summary>
    /// Add a new car
    /// </summary>
    /// <response code="201">Car created successfully</response>
    /// <response code="422">The license plate supplied is invalid, or an invalid status was supplied in the request body</response>
    /// <response code="424">An error occured while attempting to update the underlying database.</response>
    [HttpPost]
    [ProducesResponseType(typeof(CarResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
    [ProducesResponseType(StatusCodes.Status424FailedDependency)]
    public async Task<IActionResult> CreateCar([FromBody] CreateCarPayload payload)
    {
        try
        {
            var car = await _carService.CreateCar(
                payload.LicensePlate,
                payload.Colour,
                payload.ConstructionYear,
                (CarStatus) payload.Status,
                payload.Comments);
            
            var carResponse = CarResponseFactory.Construct(car);
            return new JsonResult(carResponse) {StatusCode = StatusCodes.Status201Created};
        }
        catch (Exception e) when (e is InvalidLicensePlateException or CreateCarInvalidStatusException)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status422UnprocessableEntity);
        }
        catch (InfrastructureException e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status424FailedDependency);
        }
    }

    /// <summary>
    /// Update a car's status.
    /// </summary>
    /// <response code="204">Status updated successfully</response>
    /// <response code="404">Car not found</response>
    /// <response code="422">Status is not a valid value</response>
    /// <response code="424">Something went wrong with the underlying database</response>
    [HttpPut]
    [Route("{id}/status")]
    public async Task<IActionResult> UpdateStatus(string id, [FromBody] UpdateStatusPayload payload)
    {
        try
        {
            await _carService.UpdateStatus(id, (CarStatus) payload.Status);
            return new NoContentResult();
        }
        catch (CarStatusUpdateException e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status409Conflict);
        }
        catch (CarNotFoundException e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status404NotFound);
        }
        catch (InfrastructureException e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status424FailedDependency);
        }
    }
    
    /// <summary>
    /// Lend a car to a person.
    /// </summary>
    /// <response code="204">Status and person that the car is lent to were updated successfully.</response>
    /// <response code="404">Car not found.</response>
    /// <response code="422">Name is not supplied</response>
    /// <response code="424">Something went wrong with the underlying database</response>
    [HttpPut]
    [Route("{id}/lent-to")]
    public async Task<IActionResult> UpdateLentTo(string id, [FromBody] LendCarPayload payload)
    {
        try
        {
            await _carService.LendCarTo(id, payload.PersonName);
            return new NoContentResult();
        }
        catch (CarStatusUpdateException e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status409Conflict);
        }
        catch (CarNotFoundException e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status404NotFound);
        }
        catch (InfrastructureException e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status424FailedDependency);
        }
    }
}