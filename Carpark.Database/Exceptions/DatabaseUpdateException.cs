using Microsoft.EntityFrameworkCore;

namespace Carpark.Database.Exceptions;

public class DatabaseUpdateException : Exception
{
    public DatabaseUpdateException(DbUpdateException exception)
        : base("Something went wrong while attempting to update the database", exception)
    {
    }
}