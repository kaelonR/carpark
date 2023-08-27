using Carpark.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpark.Database;

public class CarparkContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    
    protected string DbFilePath { get; init; }

    public CarparkContext()
    {
        var localApplicationDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        DbFilePath = Path.Join(localApplicationDataFolderPath, "carpark.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbFilePath}");
}