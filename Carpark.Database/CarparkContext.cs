using Bogus;
using Carpark.Domain;
using Microsoft.EntityFrameworkCore;
using Car = Carpark.Database.Entities.Car;

namespace Carpark.Database;

internal class CarparkContext : DbContext
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var colours = new[] { "Blue", "Black", "Red", "Green", "Yellow", "Orange", "White", "Purple", "Pink", "Beige", "Brown" };

        var faker = new Faker<Car>()
            .RuleFor(x => x.LicensePlate,
                f => f.Random.String2(2, "BDFGHJKLMNPRSTVWXYZ")
                     + f.Random.String2(3, "0123456789")
                     + f.Random.String2(1, "BDFGHJKLMNPRSTVWXYZ"))
            .RuleFor(x => x.Colour, f => f.PickRandom(colours))
            .RuleFor(x => x.ConstructionYear, f => f.Random.Number(2013, 2023))
            .RuleFor(x => x.LentTo, () => null)
            .RuleFor(x => x.Status, f => f.PickRandomWithout(CarStatus.LentOut))
            .RuleFor(x => x.Comments, f => f.Random.Words());

        faker.UseSeed(20230828); //static seed to ensure we have a repeatable data set.

        modelBuilder
            .Entity<Car>()
            .HasData(faker.Generate(100));
    }
}