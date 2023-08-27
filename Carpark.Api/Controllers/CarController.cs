using Carpark.Api.Contracts.Cars;
using Carpark.Api.Factories;
using Carpark.Business.Cars;
using Carpark.Business.Exceptions;
using Carpark.Business.Exceptions.Cars;
using Carpark.Business.Exceptions.Pagination;
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
    /// <param name="page">optional parameter to specify the page number to retrieve. defaults to 1.</param>
    /// <param name="itemsPerPage">optional parameter to specify how many items to put on one page. Defaults to 25. Must be between 1 and 50.</param>
    /// <response code="200">A list of cars</response>
    /// <response code="422">Request could not be processed; a status filter with an invalid value was supplied, page was 0 or lower, or itemsPerPage was not between 1 and 50.</response>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<CarResponse>), StatusCodes.Status200OK, "application/json")]
    [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> GetCars(
        [FromQuery(Name = "lent-to")] string? lentTo = null,
        [FromQuery] CarStatus? status = null,
        [FromQuery] int page = 1,
        [FromQuery(Name = "items-per-page")] int itemsPerPage = 25)
    {
        try
        {
            var (cars, totalCarCount) = await _carService.GetCars(page, itemsPerPage, lentTo, status);
            var response = new PaginatedCarsResponse
            {
                Page = page,
                ItemsPerPage = itemsPerPage,
                TotalItems = totalCarCount,
                AmountOfPages = (int) Math.Ceiling(Convert.ToDouble(totalCarCount) / itemsPerPage),
                Cars = cars.Select(CarResponseFactory.Construct)
            };
            return new JsonResult(response);
        }
        catch (Exception e) when (e is IndexOutOfRangeException or ItemsPerPageOutOfBoundsException)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status422UnprocessableEntity);
        }
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
    /// Get a car by its license plate.
    /// </summary>
    /// <param name="licensePlate"></param>
    /// <response code="200">The car</response>
    /// <response code="404">Car not found</response>
    /// <response code="424">Something went wrong with the underlying database</response>
    [HttpGet]
    [Route("{licensePlate}")]
    [ProducesResponseType(typeof(CarResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCar(string licensePlate)
    {
        try
        {
            var car = await _carService.GetCar(licensePlate);
            var response = CarResponseFactory.Construct(car);
            return new JsonResult(response);
        }
        catch (CarNotFoundException e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status404NotFound);
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
    [Route("{licensePlate}/status")]
    public async Task<IActionResult> UpdateStatus(string licensePlate, [FromBody] UpdateStatusPayload payload)
    {
        try
        {
            await _carService.UpdateStatus(licensePlate, (CarStatus) payload.Status);
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
    [Route("{licensePlate}/lent-to")]
    public async Task<IActionResult> UpdateLentTo(string licensePlate, [FromBody] LendCarPayload payload)
    {
        try
        {
            await _carService.LendCarTo(licensePlate, payload.PersonName);
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