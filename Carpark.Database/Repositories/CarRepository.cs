using Carpark.Database.Exceptions;
using Carpark.Database.Mappers;
using Carpark.Database.Repositories.Filters;
using Microsoft.EntityFrameworkCore;

namespace Carpark.Database.Repositories;

internal class CarRepository : ICarRepository
{
    private readonly CarparkContext _carparkContext;

    public CarRepository(CarparkContext carparkContext)
    {
        _carparkContext = carparkContext;
    }

    public async Task<Domain.Car?> GetCar(string licensePlate)
    {
        var dbCar = await _carparkContext.Cars.FindAsync(licensePlate);
        if (dbCar == null)
            return null;

        return CarMapper.ToDomainModel(dbCar);
    }

    public async Task<Domain.Car[]> GetCars(GetCarsFilters? filters = null)
    {
        var query = _carparkContext.Cars.AsQueryable();
        
        if (filters?.LentTo != null)
            query = query.Where(x => x.LentTo == filters.LentTo);
        if (filters?.Status != null)
            query = query.Where(x => x.Status == filters.Status);

        var dbCars = await query.ToArrayAsync();
        return dbCars.Select(CarMapper.ToDomainModel).ToArray();
    }

    /// <summary>
    /// Save a car to the database
    /// </summary>
    /// <param name="car">The car to save</param>
    /// <exception cref="DatabaseUpdateException"> Something went wrong while attempting to update the database.</exception>
    public async Task SaveCar(Domain.Car car)
    {
        var dbCar = CarMapper.ToDatabaseModel(car);

        if (_carparkContext.Cars.Any(x => x.LicensePlate == dbCar.LicensePlate))
        {
            _carparkContext.ChangeTracker.Clear();
            _carparkContext.Attach(dbCar);
            _carparkContext.Entry(dbCar).State = EntityState.Modified;
        }
        else
        {
            _carparkContext.Cars.Add(dbCar);
        }

        try
        {
            await _carparkContext.SaveChangesAsync();
        }
        catch (DbUpdateException e)
        {
            throw new DatabaseUpdateException(e);
        }
    }
}