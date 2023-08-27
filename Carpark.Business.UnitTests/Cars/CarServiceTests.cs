using Carpark.Business.Cars;
using Carpark.Business.Exceptions.Cars;
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

    private Mock<ICarRepository> CreateRepositoryMock(Car? getCarResponse = null)
    {
        var carRepositoryMock = new Mock<ICarRepository>();
        carRepositoryMock.Setup(x => x.SaveCar(It.IsAny<Car>()))
            .Returns(Task.CompletedTask);
        carRepositoryMock.Setup(x => x.GetCar(It.IsAny<string>()))
            .ReturnsAsync(getCarResponse);
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
    
    [TestCase]
    public void UpdateStatus_Throws_When_Updating_To_LentOut()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock(new Car("test plate", "Blue", 2023, CarStatus.Available));
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.ThrowsAsync<CarStatusUpdateException>(() => carService.UpdateStatus("test plate", CarStatus.LentOut));
    }
    
    [TestCase]
    public void UpdateStatus_Throws_When_Updating_To_OnOrder()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock(new Car("test plate", "Blue", 2023, CarStatus.Available));
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.ThrowsAsync<CarStatusUpdateException>(() => carService.UpdateStatus("test plate", CarStatus.OnOrder));
    }
    
    [TestCase]
    public void UpdateStatus_Throws_When_Car_IsSold()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock(new Car("test plate", "Blue", 2023, CarStatus.Sold));
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.ThrowsAsync<CarStatusUpdateException>(() => carService.UpdateStatus("test plate", CarStatus.UnderRepairs));
    }
    
    [TestCase]
    public void UpdateStatus_Throws_When_Car_Not_Found()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock();
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.ThrowsAsync<CarNotFoundException>(() => carService.UpdateStatus("test plate", CarStatus.UnderRepairs));
    }
    
    [TestCase]
    public void UpdateStatus_DoesNotThrow_When_Updating_Under_Valid_Circumstances()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock(new Car("test plate", "Blue", 2023, CarStatus.Available));
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.DoesNotThrowAsync(() => carService.UpdateStatus("test plate", CarStatus.UnderRepairs));
    }
    
    [TestCase]
    public async Task UpdateStatus_Actually_Updates_Status()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var car = new Car("test plate", "Blue", 2023, CarStatus.UnderRepairs);
        var carRepositoryMock = CreateRepositoryMock(car);
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act
        await carService.UpdateStatus("test plate", CarStatus.Available);
        
        //Assert
        Assert.That(car.Status, Is.EqualTo(CarStatus.Available));
    }
    
    [TestCase]
    public async Task LendTo_Throws_When_Car_Not_Available()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock(new Car("test plate", "Blue", 2023, CarStatus.UnderRepairs));
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.ThrowsAsync<CarStatusUpdateException>(() => carService.LendCarTo("test plate", "Jordy de Koning"));
    }
    
    [TestCase]
    public async Task LendTo_Updates_Car_To_LentOut()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var car = new Car("test plate", "Blue", 2023, CarStatus.Available);
        var carRepositoryMock = CreateRepositoryMock(car);
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act
        await carService.LendCarTo("test plate", "Jordy de Koning");
        
        //Assert
        Assert.That(car.Status, Is.EqualTo(CarStatus.LentOut));
    }
    
    [TestCase]
    public async Task LendTo_Updates_Car_LentTo_Property()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var car = new Car("test plate", "Blue", 2023, CarStatus.Available);
        var carRepositoryMock = CreateRepositoryMock(car);
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act
        await carService.LendCarTo("test plate", "Jordy de Koning");
        
        //Assert
        Assert.That(car.LentTo, Is.EqualTo("Jordy de Koning"));
    }
    
    [TestCase]
    public async Task GetCar_Throws_When_No_Car_Found()
    {
        //arrange
        var integrationMock = CreateIntegrationMock(true);
        var carRepositoryMock = CreateRepositoryMock();
        var carService = new CarService(carRepositoryMock.Object, integrationMock.Object);
        
        //Act+Assert
        Assert.ThrowsAsync<CarNotFoundException>(() => carService.GetCar("test plate"));
    }
}