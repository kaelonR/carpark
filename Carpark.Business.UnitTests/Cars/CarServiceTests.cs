using Carpark.Business.Cars;
using Carpark.Business.Exceptions;
using Carpark.Business.Integrations;
using Carpark.Database.Repositories;
using Moq;
using NUnit.Framework;

namespace Carpark.Domain.UnitTests.Cars;

public class CarServiceTests
{
    private Mock<IOpenDataRdwIntegration> CreateIntegrationMock(bool returnValue)
    {
        var mock = new Mock<IOpenDataRdwIntegration>();
        mock
            .Setup(x => x.LicensePlateExists(It.IsAny<string>()))
            .ReturnsAsync(returnValue);
        return mock;
    }

    private Mock<ICarRepository> CreateRepositoryMock()
    {
        var carRepositoryMock = new Mock<ICarRepository>();
        carRepositoryMock.Setup(x => x.SaveCar(It.IsAny<Car>()))
            .Returns(Task.CompletedTask);
        return carRepositoryMock;
    }


    [TestCase]
    public void CreateCar_Throws_When_LicensePlateInvalid()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(false);
        var carRepositoryMock = CreateRepositoryMock();
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.ThrowsAsync<InvalidLicensePlateException>(() => carService.CreateCar("blabla", "blabla", 2023, CarStatus.Available));
    }

    [TestCase]
    public void CreateCar_Throws_When_StatusInvalid()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock();
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.ThrowsAsync<CreateCarInvalidStatusException>(() => carService.CreateCar("blabla", "blabla", 2023, CarStatus.Sold));
    }

    [TestCase]
    public void CreateCar_Successful_When_AllDataIsInOrder()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock();
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.DoesNotThrowAsync(() => carService.CreateCar("blabla", "blabla", 2023, CarStatus.Available));

        carRepositoryMock.Verify(x => x.SaveCar(It.IsAny<Car>()), Times.Once);
    }
}